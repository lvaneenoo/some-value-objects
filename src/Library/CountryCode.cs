using System.Text.RegularExpressions;

namespace Common;

public sealed class CountryCode : IComparable<CountryCode>, IEquatable<CountryCode>
{
    private readonly string _value;

    private CountryCode(string value)
    {
        _value = value;
    }

    public static CountryCode Parse(string s)
    {
        if (!Regex.IsMatch(s, "^[A-Z]{2}$"))
        {
            throw new FormatException();
        }

        return new CountryCode(s);
    }

    public static bool TryParse(string s, out CountryCode? result)
    {
        if (!Regex.IsMatch(s, "^[A-Z]{2}$"))
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
