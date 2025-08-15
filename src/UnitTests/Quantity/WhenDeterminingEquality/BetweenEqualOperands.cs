using Common;

namespace QuantityTests.WhenDeterminingEquality;

public class BetweenEqualOperands
{
    [Theory]
    [InlineData(1, 1)]
    public void ShouldReturnTrue(int value1, int value2)
    {
        var sut = Quantity.FromInt32(value1);

        Assert.True(sut.Equals(Quantity.FromInt32(value2)));
    }
}
