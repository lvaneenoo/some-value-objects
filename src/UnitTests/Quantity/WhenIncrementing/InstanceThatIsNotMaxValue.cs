using Common;

namespace QuantityTests.WhenIncrementing;

[TestClass]
public class InstanceThatIsNotMaxValue
{
    private readonly Quantity _returnValue;

    public InstanceThatIsNotMaxValue()
    {
        _returnValue = Quantity.Zero.Increment();
    }

    [TestMethod]
    public void ShouldReturnIncrementedInstance()
    {
        Assert.AreEqual(Quantity.FromInt32(1), _returnValue);
    }
}
