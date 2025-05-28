using System.Diagnostics.CodeAnalysis;

namespace Common;

public readonly struct FractionalQuantity : IComparable<FractionalQuantity>, IEquatable<FractionalQuantity>
{
    public static readonly FractionalQuantity Zero;

    private readonly decimal _value;

    private FractionalQuantity(decimal value) => _value = value;

    public static FractionalQuantity FromDecimal(decimal value)
    {
        if (value < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(value),
                $"The {nameof(value)} must be a positive number or zero.");
        }

        return new(value);
    }

    public int CompareTo(FractionalQuantity other) => _value.CompareTo(other._value);
    public bool Equals(FractionalQuantity other) => _value == other._value;
    public override bool Equals([NotNullWhen(true)] object? obj) => obj is FractionalQuantity other && Equals(other);
    public override int GetHashCode() => _value.GetHashCode();
    public override string ToString() => _value.ToString();

    public static bool operator ==(FractionalQuantity a, FractionalQuantity b) => a.Equals(b);
    public static bool operator !=(FractionalQuantity a, FractionalQuantity b) => !(a == b);
    public static bool operator <(FractionalQuantity a, FractionalQuantity b) => a.CompareTo(b) < 0;
    public static bool operator >(FractionalQuantity a, FractionalQuantity b) => a.CompareTo(b) > 0;
    public static bool operator <=(FractionalQuantity a, FractionalQuantity b) => a.CompareTo(b) <= 0;
    public static bool operator >=(FractionalQuantity a, FractionalQuantity b) => a.CompareTo(b) >= 0;

    public static implicit operator decimal(FractionalQuantity a) => a._value;
}
