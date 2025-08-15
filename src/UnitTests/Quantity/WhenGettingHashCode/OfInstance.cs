using Common;

namespace QuantityTests.WhenGettingHashCode;

public class OfInstance
{
    [Fact]
    public void ShouldReturnHashCode()
    {
        const int value = 1;
        var sut = Quantity.FromInt32(value);

        Assert.Equal(value.GetHashCode(), sut.GetHashCode());
    }
}
