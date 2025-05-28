using System.Diagnostics.CodeAnalysis;

namespace Common;

public readonly struct Quantity : IComparable<Quantity>, IEquatable<Quantity>
{
    public static readonly Quantity Zero = new();

    private readonly int _value;

    private Quantity(int value) => _value = value;

    public static Quantity FromInt32(int value)
    {
        if (value < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(value), "The value must be a positive number or zero.");
        }

        return new(value);
    }

    public int CompareTo(Quantity other) => _value.CompareTo(other._value);

    public Quantity Decrement()
    {
        if (_value == 0)
        {
            throw new InvalidOperationException();
        }

        return new(_value - 1);
    }

    public bool Equals(Quantity other) => _value == other._value;
    public override bool Equals([NotNullWhen(true)] object? obj) => obj is Quantity other && Equals(other);
    public override int GetHashCode() => _value.GetHashCode();

    public Quantity Increment()
    {
        if (_value == int.MaxValue)
        {
            throw new InvalidOperationException();
        }

        return new(_value + 1);
    }

    public override string ToString() => _value.ToString();

    public static bool operator ==(Quantity a, Quantity b) => a.Equals(b);
    public static bool operator !=(Quantity a, Quantity b) => !(a == b);
    public static bool operator <(Quantity a, Quantity b) => a.CompareTo(b) < 0;
    public static bool operator >(Quantity a, Quantity b) => a.CompareTo(b) > 0;
    public static bool operator <=(Quantity a, Quantity b) => a.CompareTo(b) <= 0;
    public static bool operator >=(Quantity a, Quantity b) => a.CompareTo(b) >= 0;

    public static implicit operator int(Quantity a) => a._value;
}
