using Common;

namespace DateOfBirthTests.WhenCreatingFromDateOnly;

public class ValueThatIsValid
{
    private static readonly DateOnly MaxValue = new(2024, 12, 31);
    private static readonly DateOnly MinValue = new(1925, 1, 1);

    public static TheoryData<DateOnly> TestData =>
    [
        MinValue,
        MinValue.AddDays(1),
        MaxValue
    ];

    [Theory]
    [MemberData(nameof(TestData))]
    public void ShouldReturnInstance(DateOnly value)
    {
        _ = DateOfBirth.FromDateOnly(value);
    }
}
