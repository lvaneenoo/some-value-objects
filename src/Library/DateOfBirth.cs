namespace Common;

public sealed class DateOfBirth : IComparable<DateOfBirth>, IEquatable<DateOfBirth>
{
    private static readonly DateOnly MaxValue = new(2024, 12, 31);
    private static readonly DateOnly MinValue = new(1925, 1, 1);

    private readonly DateOnly _value;

    private DateOfBirth(DateOnly value)
    {
        _value = value;
    }

    public static DateOfBirth FromDateOnly(DateOnly value)
    {
        ArgumentOutOfRangeException.ThrowIfLessThan(value, MinValue, nameof(value));
        ArgumentOutOfRangeException.ThrowIfGreaterThan(value, MaxValue, nameof(value));

        return new DateOfBirth(value);
    }

    public int CompareTo(DateOfBirth? other) => other is null ? 1 : _value.CompareTo(other._value);
    public bool Equals(DateOfBirth? other) => other is not null && _value == other._value;
    public override bool Equals(object? obj) => Equals(obj as DateOfBirth);
    public override int GetHashCode() => _value.GetHashCode();
    public override string ToString() => _value.ToString();

    public static bool operator ==(DateOfBirth? a, DateOfBirth? b) => a is not null && a.Equals(b);
    public static bool operator !=(DateOfBirth? a, DateOfBirth? b) => !(a == b);

    public static bool operator <(DateOfBirth? a, DateOfBirth? b) => a is not null && a.CompareTo(b) < 0;
    public static bool operator >(DateOfBirth? a, DateOfBirth? b) => a is not null && a.CompareTo(b) > 0;
    public static bool operator <=(DateOfBirth? a, DateOfBirth? b) => a is not null && a.CompareTo(b) <= 0;
    public static bool operator >=(DateOfBirth? a, DateOfBirth? b) => a is not null && a.CompareTo(b) >= 0;

    public static implicit operator DateOnly(DateOfBirth a) => a._value;
}
