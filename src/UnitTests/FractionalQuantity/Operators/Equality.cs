using Common;

namespace FractionalQuantityTests.Operators;

[TestClass]
public class Equality
{
    [TestMethod]
    public void LeftDoesNotEqualRight()
        => Assert.IsFalse(FractionalQuantity.Zero == FractionalQuantity.FromDecimal(0.1M));

    [TestMethod]
    public void LeftEqualsRight()
        => Assert.IsTrue(FractionalQuantity.FromDecimal(0.1M) == FractionalQuantity.FromDecimal(0.1M));
}
