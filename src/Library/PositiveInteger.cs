namespace Common;

public sealed class PositiveInteger : IComparable<PositiveInteger>, IEquatable<PositiveInteger>
{
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

    public static bool TryParse(string s, out PositiveInteger? result)
    {
        if (int.TryParse(s, out int value) && value > 0)
        {
            result = new PositiveInteger(value);
            return true;
        }

        result = null;
        return false;
    }

    public int CompareTo(PositiveInteger? other) => other is null ? 1 : _value.CompareTo(other._value);
    public bool Equals(PositiveInteger? other) => other is not null && _value == other._value;
    public override bool Equals(object? obj) => Equals(obj as PositiveInteger);
    public override int GetHashCode() => _value.GetHashCode();
    public override string ToString() => _value.ToString();

    public static bool operator ==(PositiveInteger? a, PositiveInteger? b) => a is not null && a.Equals(b);
    public static bool operator !=(PositiveInteger? a, PositiveInteger? b) => !(a == b);
    public static bool operator <(PositiveInteger? a, PositiveInteger? b) => a is not null && a.CompareTo(b) < 0;
    public static bool operator >(PositiveInteger? a, PositiveInteger? b) => a is not null && a.CompareTo(b) > 0;
    public static bool operator <=(PositiveInteger? a, PositiveInteger? b) => a is not null && a.CompareTo(b) <= 0;
    public static bool operator >=(PositiveInteger? a, PositiveInteger? b) => a is not null && a.CompareTo(b) >= 0;

    public static implicit operator int(PositiveInteger a) => a._value;
}
