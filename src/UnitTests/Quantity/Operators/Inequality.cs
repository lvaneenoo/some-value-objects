using Common;

namespace QuantityTests.Operators;

[TestClass]
public class Inequality
{
    [TestMethod]
    public void LeftDoesNotEqualRight() => Assert.IsTrue(Quantity.Zero != Quantity.FromInt32(1));

    [TestMethod]
    public void LeftEqualsRight() => Assert.IsFalse(Quantity.FromInt32(1) != Quantity.FromInt32(1));
}
