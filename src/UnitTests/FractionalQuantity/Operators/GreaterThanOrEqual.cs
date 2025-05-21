using Common;

namespace FractionalQuantityTests.Operators;

[TestClass]
public class GreaterThanOrEqual
{
    [TestMethod]
    public void LeftEqualsRight()
        => Assert.IsTrue(FractionalQuantity.FromDecimal(0.1M) >= FractionalQuantity.FromDecimal(0.1M));

    [TestMethod]
    public void LeftIsGreaterThanRight()
        => Assert.IsTrue(FractionalQuantity.FromDecimal(0.1M) >= FractionalQuantity.Zero);

    [TestMethod]
    public void LeftIsLessThanRight()
        => Assert.IsFalse(FractionalQuantity.Zero >= FractionalQuantity.FromDecimal(0.1M));
}
