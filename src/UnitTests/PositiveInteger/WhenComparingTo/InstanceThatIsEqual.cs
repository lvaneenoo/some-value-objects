using Common;

namespace PositiveIntegerTests.WhenComparingTo;

public class InstanceThatIsEqual
{
    [Theory]
    [InlineData(1, 1)]
    public void ShouldReturnZero(int value1, int value2)
    {
        var sut = PositiveInteger.FromInt32(value1);

        Assert.Equal(0, sut.CompareTo(PositiveInteger.FromInt32(value2)));
    }
}
