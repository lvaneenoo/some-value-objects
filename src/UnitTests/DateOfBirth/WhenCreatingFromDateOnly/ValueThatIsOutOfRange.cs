using Common;

namespace DateOfBirthTests.WhenCreatingFromDateOnly;

public class ValueThatIsOutOfRange
{
    public static IEnumerable<object[]> CreateArgs()
    {
        yield return new object[]
        {
            MinValue.AddDays(-1)
        };

        yield return new object[]
        {
            MaxValue.AddDays(1)
        };
    }

    private static readonly DateOnly MaxValue = new(2024, 12, 31);
    private static readonly DateOnly MinValue = new(1925, 1, 1);

    [Theory]
    [MemberData(nameof(CreateArgs))]
    public void ShouldThrowArgumentOutOfRangeException(DateOnly value)
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => _ = DateOfBirth.FromDateOnly(value));
    }
}
