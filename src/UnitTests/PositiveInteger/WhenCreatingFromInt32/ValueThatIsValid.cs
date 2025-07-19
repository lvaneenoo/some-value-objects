using Common;

namespace PositiveIntegerTests.WhenCreatingFromInt32;

public class ValueThatIsValid
{
    [Theory]
    [InlineData(1)]
    public void ShouldReturnInstance(int value)
    {
        Assert.Equal(value, PositiveInteger.FromInt32(value));
    }
}
