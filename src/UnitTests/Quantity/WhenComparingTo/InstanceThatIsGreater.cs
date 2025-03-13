using Common;

namespace QuantityTests.WhenComparingTo;

[TestClass]
public class InstanceThatIsGreater
{
    [TestMethod]
    public void ShouldReturnMinusOne() => Assert.AreEqual(-1, Quantity.Zero.CompareTo(Quantity.FromInt32(1)));
}
