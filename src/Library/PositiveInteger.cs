using System.Diagnostics.CodeAnalysis;

namespace Common;

public readonly struct PositiveInteger : IComparable<PositiveInteger>, IEquatable<PositiveInteger>
{
    public static readonly PositiveInteger Unknown;

    private readonly int _value;

    private PositiveInteger(int value) => _value = value;

    public static PositiveInteger FromInt32(int value)
    {
        if (value < 1)
        {
            throw new ArgumentOutOfRangeException(nameof(value), $"The {nameof(value)} must be a positive number.");
        }

        return new PositiveInteger(value);
    }

    public static bool TryParse(string s, out PositiveInteger result)
    {
        if (int.TryParse(s, out int value) && value > 0)
        {
            result = new PositiveInteger(value);
            return true;
        }

        result = Unknown;
        return false;
    }

    public int CompareTo(PositiveInteger other) => _value.CompareTo(other._value);
    public bool Equals(PositiveInteger other) => _value == other._value;
    public override bool Equals([NotNullWhen(true)] object? obj) => obj is PositiveInteger other && Equals(other);
    public override int GetHashCode() => _value.GetHashCode();
    public override string ToString() => _value == 0 ? "Unknown" : _value.ToString();

    public static bool operator ==(PositiveInteger a, PositiveInteger b) => a.Equals(b);
    public static bool operator !=(PositiveInteger a, PositiveInteger b) => !(a == b);
    public static bool operator <(PositiveInteger a, PositiveInteger b) => a.CompareTo(b) < 0;
    public static bool operator >(PositiveInteger a, PositiveInteger b) => a.CompareTo(b) > 0;
    public static bool operator <=(PositiveInteger a, PositiveInteger b) => a.CompareTo(b) <= 0;
    public static bool operator >=(PositiveInteger a, PositiveInteger b) => a.CompareTo(b) >= 0;

    public static implicit operator int(PositiveInteger a) => a._value;
}
