using Common;

namespace DateOfBirthTests.WhenDeterminingEquality;

public class BetweenEqualOperands
{
    private static readonly DateOnly Value = new(1925, 1, 1);

    public static TheoryData<DateOnly, DateOnly> TestData => new()
    {
        { Value, Value }
    };

    [Theory]
    [MemberData(nameof(TestData))]
    public void ShouldReturnTrue(DateOnly value1, DateOnly value2)
    {
        var sut = DateOfBirth.FromDateOnly(value1);

        Assert.True(sut.Equals(DateOfBirth.FromDateOnly(value2)));
    }
}
