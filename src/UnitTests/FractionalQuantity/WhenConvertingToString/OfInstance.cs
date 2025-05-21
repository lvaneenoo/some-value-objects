using Common;

namespace FractionalQuantityTests.WhenConvertingToString;

[TestClass]
public class OfInstance
{
    [TestMethod]
    public void ShouldReturnValue() => Assert.AreEqual("0", FractionalQuantity.Zero.ToString());
}
