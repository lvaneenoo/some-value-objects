using Common;

namespace QuantityTests.WhenComparingTo;

[TestClass]
public class InstanceThatIsEqual
{
    private readonly int _returnValue;

    public InstanceThatIsEqual()
    {
        _returnValue = Quantity.Zero.CompareTo(Quantity.Zero);
    }

    [TestMethod]
    public void ShouldReturnZero()
    {
        Assert.AreEqual(0, _returnValue);
    }
}
