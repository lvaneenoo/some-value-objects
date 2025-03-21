using System.Diagnostics.CodeAnalysis;
using System.Text.RegularExpressions;

namespace Common;

public readonly struct CountryCode : IComparable<CountryCode>, IEquatable<CountryCode>
{
    public static readonly CountryCode Unknown;

    private readonly string? _value;

    private CountryCode(string value) => _value = value;

    public static CountryCode Parse(string s)
    {
        if (Regex.IsMatch(s, "[A-Z]{2}"))
        {
            return new(s);
        }

        throw new FormatException();
    }

    public static bool TryParse(string s, out CountryCode result)
    {
        if (Regex.IsMatch(s, "[A-Z]{2}"))
        {
            result = new(s);
            return true;
        }

        result = Unknown;
        return false;
    }

    public int CompareTo(CountryCode other)
    {
        if (_value == null && other._value == null)
        {
            return 0;
        }

        if (_value == null)
        {
            return -1;
        }

        return other._value == null ? 1 : _value.CompareTo(other._value);
    }

    public bool Equals(CountryCode other) => _value == other._value;
    public override bool Equals([NotNullWhen(true)] object? obj) => obj is CountryCode other && Equals(other);
    public override int GetHashCode() => _value == null ? 0 : _value.GetHashCode();
    public override string ToString() => _value ?? "Unknown";

    public static bool operator ==(CountryCode a, CountryCode b) => a.Equals(b);
    public static bool operator !=(CountryCode a, CountryCode b) => !(a == b);
    public static bool operator <(CountryCode a, CountryCode b) => a.CompareTo(b) < 0;
    public static bool operator >(CountryCode a, CountryCode b) => a.CompareTo(b) > 0;
    public static bool operator <=(CountryCode a, CountryCode b) => a.CompareTo(b) <= 0;
    public static bool operator >=(CountryCode a, CountryCode b) => a.CompareTo(b) >= 0;
}
