using Common;

namespace QuantityTests.WhenComparingTo;

[TestClass]
public class InstanceThatIsEqual
{
    [TestMethod]
    public void ShouldReturnZero() => Assert.AreEqual(0, Quantity.Zero.CompareTo(Quantity.Zero));
}
