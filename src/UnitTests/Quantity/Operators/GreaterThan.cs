using Common;

namespace QuantityTests.Operators;

[TestClass]
public class GreaterThan
{
    [TestMethod]
    public void LeftEqualsRight() => Assert.IsFalse(Quantity.FromInt32(1) > Quantity.FromInt32(1));

    [TestMethod]
    public void LeftIsGreaterThanRight() => Assert.IsTrue(Quantity.FromInt32(1) > Quantity.Zero);

    [TestMethod]
    public void LeftIsLessThanRight() => Assert.IsFalse(Quantity.Zero > Quantity.FromInt32(1));
}
