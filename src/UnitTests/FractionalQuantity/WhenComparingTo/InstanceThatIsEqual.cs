using Common;

namespace FractionalQuantityTests.WhenComparingTo;

[TestClass]
public class InstanceThatIsEqual
{
    [TestMethod]
    public void ShouldReturnZero() => Assert.AreEqual(0, FractionalQuantity.Zero.CompareTo(FractionalQuantity.Zero));
}
