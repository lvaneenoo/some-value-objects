using Common;

namespace QuantityTests.WhenComparingTo;

[TestClass]
public class InstanceThatIsGreater
{
    private readonly int _returnValue;

    public InstanceThatIsGreater()
    {
        _returnValue = Quantity.Zero.CompareTo(Quantity.FromInt32(1));
    }

    [TestMethod]
    public void ShouldReturnMinusOne()
    {
        Assert.AreEqual(-1, _returnValue);
    }
}
