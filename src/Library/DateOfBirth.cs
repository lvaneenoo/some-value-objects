using System.Diagnostics.CodeAnalysis;

namespace Common;

public readonly struct DateOfBirth : IComparable<DateOfBirth>, IEquatable<DateOfBirth>
{
    public static readonly DateOfBirth Unknown;

    private static readonly DateOnly MaxValue = new(2024, 12, 31);
    private static readonly DateOnly MinValue = new(1925, 1, 1);

    private readonly DateOnly _value;

    private DateOfBirth(DateOnly value) => _value = value;

    public static DateOfBirth FromDateOnly(DateOnly value)
    {
        ArgumentOutOfRangeException.ThrowIfLessThan(value, MinValue);
        ArgumentOutOfRangeException.ThrowIfGreaterThan(value, MaxValue);

        return new DateOfBirth(value);
    }

    public int CompareTo(DateOfBirth other) => _value.CompareTo(other._value);
    public bool Equals(DateOfBirth other) => _value == other._value;
    public override bool Equals([NotNullWhen(true)] object? obj) => obj is DateOfBirth other && Equals(other);
    public override int GetHashCode() => _value.GetHashCode();
    public override string ToString() => _value == DateOnly.MinValue ? "Unknown" : _value.ToString();

    public static bool operator ==(DateOfBirth a, DateOfBirth b) => a.Equals(b);
    public static bool operator !=(DateOfBirth a, DateOfBirth b) => !(a == b);
    public static bool operator <(DateOfBirth a, DateOfBirth b) => a.CompareTo(b) < 0;
    public static bool operator >(DateOfBirth a, DateOfBirth b) => a.CompareTo(b) > 0;
    public static bool operator <=(DateOfBirth a, DateOfBirth b) => a.CompareTo(b) <= 0;
    public static bool operator >=(DateOfBirth a, DateOfBirth b) => a.CompareTo(b) >= 0;

    public static implicit operator DateOnly(DateOfBirth a) => a._value;
}
