using Common;

namespace QuantityTests.WhenCreatingFromInt32;

public class ValueThatIsOutOfRange
{
    [Theory]
    [InlineData(-1)]
    public void ShouldThrowArgumentOutOfRangeException(int value)
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => _ = Quantity.FromInt32(value));
    }
}
