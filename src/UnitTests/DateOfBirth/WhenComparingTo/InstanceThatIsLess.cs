using Common;

namespace DateOfBirthTests.WhenComparingTo;

public class InstanceThatIsLess
{
    private static readonly DateOnly Value = new(1925, 1, 2);

    public static TheoryData<DateOnly, DateOnly> TestData => new()
    {
        { Value, Value.AddDays(-1) }
    };

    [Theory]
    [MemberData(nameof(TestData))]
    public void ShouldReturnOne(DateOnly value1, DateOnly value2)
    {
        var sut = DateOfBirth.FromDateOnly(value1);

        Assert.Equal(1, sut.CompareTo(DateOfBirth.FromDateOnly(value2)));
    }
}
