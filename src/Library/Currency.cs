using System.Diagnostics.CodeAnalysis;
using System.Text.RegularExpressions;

namespace Common;

public sealed class Currency : IComparable<Currency>, IEquatable<Currency>, IParsable<Currency>
{
    private const string Pattern = "^[A-Z]{3}$";

    private static readonly HashSet<string> AllowedValues =
    [
        "EUR",
        "GBP",
        "USD"
    ];

    private readonly string _value;

    private Currency(string value)
    {
        _value = value;
    }

    public static Currency Parse(string s, IFormatProvider? provider)
    {
        if (!Regex.IsMatch(s, Pattern))
        {
            throw new FormatException();
        }

        if (!AllowedValues.Contains(s))
        {
            throw new ArgumentOutOfRangeException(nameof(s));
        }

        return new Currency(s);
    }

    public static bool TryParse([NotNullWhen(true)] string? s,
                                IFormatProvider? provider,
                                [MaybeNullWhen(false)] out Currency result)
    {
        if (s is null || !Regex.IsMatch(s, Pattern) || !AllowedValues.Contains(s))
        {
            result = null;
            return false;
        }

        result = new Currency(s);
        return true;
    }

    public int CompareTo(Currency? other) => other is null ? 1 : _value.CompareTo(other._value);
    public bool Equals(Currency? other) => other is not null && _value == other._value;
    public override bool Equals(object? obj) => Equals(obj as Currency);
    public override int GetHashCode() => _value.GetHashCode();
    public override string ToString() => _value;

    public static bool operator ==(Currency? a, Currency? b) => a is not null && a.Equals(b);
    public static bool operator !=(Currency? a, Currency? b) => !(a == b);

    public static bool operator <(Currency? a, Currency? b) => a is not null && a.CompareTo(b) < 0;
    public static bool operator >(Currency? a, Currency? b) => a is not null && a.CompareTo(b) > 0;
    public static bool operator <=(Currency? a, Currency? b) => a is not null && a.CompareTo(b) <= 0;
    public static bool operator >=(Currency? a, Currency? b) => a is not null && a.CompareTo(b) >= 0;

    public static implicit operator string(Currency a) => a.ToString();
}
