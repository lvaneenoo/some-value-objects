using System.Diagnostics.CodeAnalysis;

namespace Common;

public readonly struct Name : IComparable<Name>, IEquatable<Name>
{
    public static readonly Name Unknown;

    private readonly string? _value;

    private Name(string value) => _value = value;

    public static Name FromString(string value)
    {
        if (value.Trim() == "" || value.Length > 50)
        {
            throw new FormatException();
        }

        return new Name(value);
    }

    public int CompareTo(Name other)
        => _value switch
        {
            null when other._value == null => 0,
            null => -1,
            _ => other._value == null ? 1 : _value.CompareTo(other._value)
        };

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

    public static implicit operator string(Name a) => a.ToString();
}
