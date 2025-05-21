using Common;

namespace FractionalQuantityTests.WhenGettingHashCode;

[TestClass]
public class OfInstanceThatIsZero
{
    [TestMethod]
    public void ShouldReturnZero() => Assert.AreEqual(0, FractionalQuantity.Zero.GetHashCode());
}
