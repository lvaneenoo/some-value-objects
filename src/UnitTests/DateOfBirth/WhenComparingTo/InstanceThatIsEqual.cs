using Common;

namespace DateOfBirthTests.WhenComparingTo;

public class InstanceThatIsEqual
{
    private static readonly DateOnly Value = new(1925, 1, 1);

    public static TheoryData<DateOnly, DateOnly> TestData => new()
    {
        { Value, Value }
    };

    [Theory]
    [MemberData(nameof(TestData))]
    public void ShouldReturnZero(DateOnly value1, DateOnly value2)
    {
        var sut = DateOfBirth.FromDateOnly(value1);

        Assert.Equal(0, sut.CompareTo(DateOfBirth.FromDateOnly(value2)));
    }
}
