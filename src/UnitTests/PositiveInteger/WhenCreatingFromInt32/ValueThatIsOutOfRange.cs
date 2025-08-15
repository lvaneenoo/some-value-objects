using Common;

namespace PositiveIntegerTests.WhenCreatingFromInt32;

public class ValueThatIsOutOfRange
{
    [Theory]
    [InlineData(int.MinValue)]
    [InlineData(-1)]
    [InlineData(0)]
    public void ShouldThrowArgumentOutOfRangeException(int value)
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => _ = PositiveInteger.FromInt32(value));
    }
}
