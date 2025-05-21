using Common;

namespace FractionalQuantityTests.WhenComparingTo;

[TestClass]
public class InstanceThatIsLess
{
    private readonly int _returnValue;

    public InstanceThatIsLess()
    {
        var sut = FractionalQuantity.FromDecimal(0.1M);

        _returnValue = sut.CompareTo(FractionalQuantity.Zero);
    }

    [TestMethod]
    public void ShouldReturnOne() => Assert.AreEqual(1, _returnValue);
}
