using Common;

namespace DateOfBirthTests.WhenCreatingFromDateOnly;

public class ValueThatIsOutOfRange
{
    private static readonly DateOnly MaxValue = new(2024, 12, 31);
    private static readonly DateOnly MinValue = new(1925, 1, 1);

    public static TheoryData<DateOnly> CreateArgs() =>
    [
        MinValue.AddDays(-1),
        MaxValue.AddDays(1)
    ];

    [Theory]
    [MemberData(nameof(CreateArgs))]
    public void ShouldThrowArgumentOutOfRangeException(DateOnly value)
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => DateOfBirth.FromDateOnly(value));
    }
}
