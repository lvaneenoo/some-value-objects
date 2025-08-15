using Common;

namespace FractionalQuantityTests.WhenConvertingToString;

public class Instance
{
    [Fact]
    public void ShouldReturnValue()
    {
        const decimal value = 0.1M;
        var sut = FractionalQuantity.FromDecimal(value);

        Assert.Equal(value.ToString(), sut.ToString());
    }
}
