using System.Diagnostics.CodeAnalysis;

namespace Common;

public readonly struct Name : IComparable<Name>, IEquatable<Name>
{
    public static readonly Name Unknown;

    private readonly string? _value;

    private Name(string value) => _value = value;

    public static Name Parse(string s)
    {
        if (s.Trim() == "" || s.Length > 50)
        {
            throw new FormatException();
        }

        return new Name(s);
    }

    public static bool TryParse(string s, out Name result)
    {
        if (s.Trim() == "" || s.Length > 50)
        {
            result = Unknown;
            return false;
        }

        result = new Name(s);
        return true;
    }

    public int CompareTo(Name other)
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

    public bool Equals(Name other) => _value == other._value;
    public override bool Equals([NotNullWhen(true)] object? obj) => obj is Name other && Equals(other);
    public override int GetHashCode() => _value == null ? 0 : _value.GetHashCode();
    public override string ToString() => _value ?? "Unknown";

    public static bool operator ==(Name a, Name b) => a.Equals(b);
    public static bool operator !=(Name a, Name b) => !(a == b);
    public static bool operator <(Name a, Name b) => a.CompareTo(b) < 0;
    public static bool operator >(Name a, Name b) => a.CompareTo(b) > 0;
    public static bool operator <=(Name a, Name b) => a.CompareTo(b) <= 0;
    public static bool operator >=(Name a, Name b) => a.CompareTo(b) >= 0;
}
