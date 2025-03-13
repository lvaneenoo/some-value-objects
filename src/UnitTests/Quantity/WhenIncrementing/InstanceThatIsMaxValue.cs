using Common;

namespace QuantityTests.WhenIncrementing;

[TestClass]
public class InstanceThatIsMaxValue
{
    private readonly InvalidOperationException? _exception;

    public InstanceThatIsMaxValue()
    {
        try
        {
            var sut = Quantity.FromInt32(int.MaxValue);

            sut.Increment();
        }
        catch (InvalidOperationException ex)
        {
            _exception = ex;
        }
    }

    [TestMethod]
    public void ShouldThrowInvalidOperationException() => Assert.IsNotNull(_exception);
}
