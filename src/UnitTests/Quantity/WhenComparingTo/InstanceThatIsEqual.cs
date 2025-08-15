using Common;

namespace QuantityTests.WhenComparingTo;

public class InstanceThatIsEqual
{
    [Theory]
    [InlineData(1, 1)]
    public void ShouldReturnZero(int value1, int value2)
    {
        var sut = Quantity.FromInt32(value1);

        Assert.Equal(0, sut.CompareTo(Quantity.FromInt32(value2)));
    }
}
