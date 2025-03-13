using Common;

namespace QuantityTests.WhenDecrementing;

[TestClass]
public class InstanceThatIsZero
{
    private readonly InvalidOperationException? _exception;

    public InstanceThatIsZero()
    {
        try
        {
            Quantity.Zero.Decrement();
        }
        catch (InvalidOperationException ex)
        {
            _exception = ex;
        }
    }

    [TestMethod]
    public void ShouldThrowInvalidOperationException() => Assert.IsNotNull(_exception);
}
