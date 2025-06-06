using Common;

namespace QuantityTests.WhenCreatingFromInt32;

public class ValueThatIsValid
{
    [Theory]
    [InlineData(0)]
    public void ShouldReturnInstance(int value)
    {
        Quantity sut = Quantity.FromInt32(value);

        Assert.Equal(value.GetHashCode(), sut.GetHashCode());
        Assert.Equal(value.ToString(), sut.ToString());
    }
}
