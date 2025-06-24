using System.Diagnostics.CodeAnalysis;
using System.Text.RegularExpressions;

namespace Common;

public readonly struct Currency : IComparable<Currency>, IEquatable<Currency>
{
    public static readonly Currency Unknown;

    private static readonly HashSet<string> AllowedValues =
    [
        "EUR",
        "GBP",
        "USD"
    ];

    private readonly string? _value;

    private Currency(string value) => _value = value;

    public static Currency Parse(string s)
    {
        if (!Regex.IsMatch(s, "[A-Z]{3}"))
        {
            throw new FormatException();
        }

        if (!AllowedValues.Contains(s))
        {
            throw new ArgumentOutOfRangeException();
        }

        return new Currency(s);
    }

    public static bool TryParse(string s, out Currency result)
    {
        if (!Regex.IsMatch(s, "[A-Z]{3}"))
        {
            result = Unknown;
            return false;
        }

        if (!AllowedValues.Contains(s))
        {
            result = Unknown;
            return false;
        }

        result = new Currency(s);
        return true;
    }

    public int CompareTo(Currency other)
        => _value switch
        {
            null when other._value == null => 0,
            null => -1,
            _ => other._value == null ? 1 : _value.CompareTo(other._value)
        };

    public bool Equals(Currency other) => _value == other._value;
    public override bool Equals([NotNullWhen(true)] object? obj) => obj is Currency other && Equals(other);
    public override int GetHashCode() => _value == null ? 0 : _value.GetHashCode();
    public override string ToString() => _value ?? "Unknown";

    public static bool operator ==(Currency a, Currency b) => a.Equals(b);
    public static bool operator !=(Currency a, Currency b) => !(a == b);
    public static bool operator <(Currency a, Currency b) => a.CompareTo(b) < 0;
    public static bool operator >(Currency a, Currency b) => a.CompareTo(b) > 0;
    public static bool operator <=(Currency a, Currency b) => a.CompareTo(b) <= 0;
    public static bool operator >=(Currency a, Currency b) => a.CompareTo(b) >= 0;

    public static implicit operator string(Currency a) => a.ToString();
}
