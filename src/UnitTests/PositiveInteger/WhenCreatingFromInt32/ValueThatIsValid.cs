using Common;

namespace PositiveIntegerTests.WhenCreatingFromInt32;

public class ValueThatIsValid
{
    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(int.MaxValue)]
    public void ShouldReturnInstance(int value)
    {
        _ = PositiveInteger.FromInt32(value);
    }
}
