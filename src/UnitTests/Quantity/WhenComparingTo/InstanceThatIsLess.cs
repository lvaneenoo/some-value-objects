using Common;

namespace QuantityTests.WhenComparingTo;

[TestClass]
public class InstanceThatIsLess
{
    private readonly int _returnValue;

    public InstanceThatIsLess()
    {
        var sut = Quantity.FromInt32(1);

        _returnValue = sut.CompareTo(Quantity.Zero);
    }

    [TestMethod]
    public void ShouldReturnOne() => Assert.AreEqual(1, _returnValue);
}
