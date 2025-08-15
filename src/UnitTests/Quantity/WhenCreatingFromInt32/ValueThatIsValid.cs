using Common;

namespace QuantityTests.WhenCreatingFromInt32;

public class ValueThatIsValid
{
    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    [InlineData(int.MaxValue)]
    public void ShouldReturnInstance(int value)
    {
        _ = Quantity.FromInt32(value);
    }
}
