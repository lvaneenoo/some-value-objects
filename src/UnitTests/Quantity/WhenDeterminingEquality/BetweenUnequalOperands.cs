using Common;

namespace QuantityTests.WhenDeterminingEquality;

public class BetweenUnequalOperands
{
    [Theory]
    [InlineData(1, 2)]
    public void ShouldReturnFalse(int value1, int value2)
    {
        var sut = Quantity.FromInt32(value1);

        Assert.False(sut.Equals(Quantity.FromInt32(value2)));
    }
}
