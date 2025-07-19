using Common;

namespace DateOfBirthTests.WhenCreatingFromDateOnly;

public class ValueThatIsValid
{
    private static readonly DateOnly MinValue = new(1925, 1, 1);

    public static TheoryData<DateOnly> CreateArgs() =>
    [
        MinValue
    ];

    [Theory]
    [MemberData(nameof(CreateArgs))]
    public void ShouldReturnInstance(DateOnly value)
    {
        Assert.Equal(value, DateOfBirth.FromDateOnly(value));
    }
}
