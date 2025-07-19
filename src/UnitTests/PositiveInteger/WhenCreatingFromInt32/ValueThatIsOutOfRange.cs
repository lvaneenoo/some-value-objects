using Common;

namespace PositiveIntegerTests.WhenCreatingFromInt32;

public class ValueThatIsOutOfRange
{
    [Theory]
    [InlineData(0)]
    public void ShouldThrowArgumentOutOfRangeException(int value)
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => PositiveInteger.FromInt32(value)); 
    }
}
