using Common;

namespace FractionalQuantityTests.WhenGettingHashCode;

public class OfInstance
{
    [Fact]
    public void ShouldReturnHashCode()
    {
        const decimal value = 0.1M;
        var sut = FractionalQuantity.FromDecimal(value);

        Assert.Equal(value.GetHashCode(), sut.GetHashCode());
    }
}
