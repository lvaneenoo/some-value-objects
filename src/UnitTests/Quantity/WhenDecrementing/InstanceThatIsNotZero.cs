using Common;

namespace QuantityTests.WhenDecrementing;

[TestClass]
public class InstanceThatIsNotZero
{
    private readonly Quantity _returnValue;

    public InstanceThatIsNotZero()
    {
        var sut = Quantity.FromInt32(1);

        _returnValue = sut.Decrement();
    }

    [TestMethod]
    public void ShouldReturnDecrementedInstance()
    {
        Assert.AreEqual(Quantity.Zero, _returnValue);
    }
}
