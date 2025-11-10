using System.Diagnostics.CodeAnalysis;
using System.Text.RegularExpressions;

namespace Common;

public sealed class CountryCode : IComparable<CountryCode>, IEquatable<CountryCode>, IParsable<CountryCode>
{
    private const string Pattern = "^[A-Z]{2}$";

    private readonly string _value;

    private CountryCode(string value)
    {
        _value = value;
    }

    public static CountryCode Parse(string s, IFormatProvider? provider)
    {
        if (!Regex.IsMatch(s, Pattern))
        {
            throw new FormatException();
        }

        return new CountryCode(s);
    }

    public static bool TryParse([NotNullWhen(true)] string? s,
                                IFormatProvider? provider,
                                [MaybeNullWhen(false)] out CountryCode result)
    {
        if (s is null || !Regex.IsMatch(s, Pattern))
        {
            result = null;
            return false;
        }

        result = new CountryCode(s);
        return true;
    }

    public int CompareTo(CountryCode? other) => other is null ? 1 : _value.CompareTo(other._value);
    public bool Equals(CountryCode? other) => other is not null && _value == other._value;
    public override bool Equals(object? obj) => Equals(obj as CountryCode);
    public override int GetHashCode() => _value.GetHashCode();
    public override string ToString() => _value;

    public static bool operator ==(CountryCode? a, CountryCode? b) => a is not null && a.Equals(b);
    public static bool operator !=(CountryCode? a, CountryCode? b) => !(a == b);

    public static bool operator <(CountryCode? a, CountryCode? b) => a is not null && a.CompareTo(b) < 0;
    public static bool operator >(CountryCode? a, CountryCode? b) => a is not null && a.CompareTo(b) > 0;
    public static bool operator <=(CountryCode? a, CountryCode? b) => a is not null && a.CompareTo(b) <= 0;
    public static bool operator >=(CountryCode? a, CountryCode? b) => a is not null && a.CompareTo(b) >= 0;

    public static implicit operator string(CountryCode a) => a.ToString();
}
