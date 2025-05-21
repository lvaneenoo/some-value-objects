using Common;

namespace FractionalQuantityTests.WhenComparingTo;

[TestClass]
public class InstanceThatIsGreater
{
    [TestMethod]
    public void ShouldReturnMinusOne()
        => Assert.AreEqual(-1, FractionalQuantity.Zero.CompareTo(FractionalQuantity.FromDecimal(0.1M)));
}
