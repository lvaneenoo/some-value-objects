using Common;

namespace QuantityTests.WhenConvertingToString;

public class Instance
{
    [Fact]
    public void ShouldReturnValue()
    {
        const int value = 1;
        var sut = Quantity.FromInt32(value);

        Assert.Equal(value.ToString(), sut.ToString());
    }
}
