using Common;

namespace DateOfBirthTests.WhenDeterminingEquality;

public class BetweenUnequalOperands
{
    private static readonly DateOnly Value = new(1925, 1, 1);

    public static TheoryData<DateOnly, DateOnly> TestData => new()
    {
        { Value, Value.AddDays(1) }
    };

    [Theory]
    [MemberData(nameof(TestData))]
    public void ShouldReturnFalse(DateOnly value1, DateOnly value2)
    {
        var sut = DateOfBirth.FromDateOnly(value1);

        Assert.False(sut.Equals(DateOfBirth.FromDateOnly(value2)));
    }
}
