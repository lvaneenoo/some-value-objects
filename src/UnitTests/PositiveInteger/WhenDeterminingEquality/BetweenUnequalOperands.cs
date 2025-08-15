using Common;

namespace PositiveIntegerTests.WhenDeterminingEquality;

public class BetweenUnequalOperands
{
    [Theory]
    [InlineData(1, 2)]
    public void ShouldReturnFalse(int value1, int value2)
    {
        var sut = PositiveInteger.FromInt32(value1);

        Assert.False(sut.Equals(PositiveInteger.FromInt32(value2)));
    }
}
