namespace Common;

public sealed class Name : IComparable<Name>, IEquatable<Name>
{
    private const int MaxLength = 50;

    private readonly string _value;

    private Name(string value) => _value = value;

    public static Name Parse(string s)
    {
        if (s.Length > MaxLength || s.Trim() == "")
        {
            throw new FormatException();
        }

        return new Name(s);
    }

    public int CompareTo(Name? other) => other is null ? 1 : _value.CompareTo(other._value);
    public bool Equals(Name? other) => other is not null && _value == other._value;
    public override bool Equals(object? obj) => Equals(obj as Name);
    public override int GetHashCode() => _value.GetHashCode();
    public override string ToString() => _value;

    public static bool operator ==(Name? a, Name? b) => a is not null && a.Equals(b);
    public static bool operator !=(Name? a, Name? b) => !(a == b);
    public static bool operator <(Name? a, Name? b) => a is not null && a.CompareTo(b) < 0;
    public static bool operator >(Name? a, Name? b) => a is not null && a.CompareTo(b) > 0;
    public static bool operator <=(Name? a, Name? b) => a is not null && a.CompareTo(b) <= 0;
    public static bool operator >=(Name? a, Name? b) => a is not null && a.CompareTo(b) >= 0;

    public static implicit operator string(Name a) => a.ToString();
}
