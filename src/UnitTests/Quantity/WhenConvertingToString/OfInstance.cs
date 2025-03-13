using Common;

namespace QuantityTests.WhenConvertingToString;

[TestClass]
public class OfInstance
{
    [TestMethod]
    public void ShouldReturnValue() => Assert.AreEqual("0", Quantity.Zero.ToString());
}
