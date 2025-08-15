using Common;

namespace QuantityTests.WhenComparingTo;

public class InstanceThatIsGreater
{
    [Theory]
    [InlineData(1, 2)]
    public void ShouldReturnMinusOne(int value1, int value2)
    {
        var sut = Quantity.FromInt32(value1);

        Assert.Equal(-1, sut.CompareTo(Quantity.FromInt32(value2)));
    }
}
