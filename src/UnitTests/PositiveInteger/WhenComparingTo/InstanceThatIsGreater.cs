using Common;

namespace PositiveIntegerTests.WhenComparingTo;

public class InstanceThatIsGreater
{
    [Theory]
    [InlineData(1, 2)]
    public void ShouldReturnMinusOne(int value1, int value2)
    {
        var sut = PositiveInteger.FromInt32(value1);

        Assert.Equal(-1, sut.CompareTo(PositiveInteger.FromInt32(value2)));
    }
}
