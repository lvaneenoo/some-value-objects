using Common;

namespace FractionalQuantityTests.Operators;

[TestClass]
public class Inequality
{
    [TestMethod]
    public void LeftDoesNotEqualRight()
        => Assert.IsTrue(FractionalQuantity.Zero != FractionalQuantity.FromDecimal(0.1M));

    [TestMethod]
    public void LeftEqualsRight()
        => Assert.IsFalse(FractionalQuantity.FromDecimal(0.1M) != FractionalQuantity.FromDecimal(0.1M));
}
