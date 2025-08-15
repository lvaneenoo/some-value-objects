using Common;

namespace QuantityTests.WhenComparingTo;

public class InstanceThatIsLess
{
    [Theory]
    [InlineData(2, 1)]
    public void ShouldReturnOne(int value1, int value2)
    {
        var sut = Quantity.FromInt32(value1);

        Assert.Equal(1, sut.CompareTo(Quantity.FromInt32(value2)));
    }
}
