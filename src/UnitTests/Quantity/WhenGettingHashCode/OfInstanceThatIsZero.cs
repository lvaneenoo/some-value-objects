using Common;

namespace QuantityTests.WhenGettingHashCode;

[TestClass]
public class OfInstanceThatIsZero
{
    [TestMethod]
    public void ShouldReturnZero()
    {
        Assert.AreEqual(0, Quantity.Zero.GetHashCode());
    }
}
