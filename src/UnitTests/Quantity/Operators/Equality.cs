using Common;

namespace QuantityTests.Operators;

[TestClass]
public class Equality
{
    [TestMethod]
    public void LeftDoesNotEqualRight() => Assert.IsFalse(Quantity.Zero == Quantity.FromInt32(1));

    [TestMethod]
    public void LeftEqualsRight() => Assert.IsTrue(Quantity.FromInt32(1) == Quantity.FromInt32(1));
}
