using Common;

namespace QuantityTests.Operators;

[TestClass]
public class LessThanOrEqual
{
    [TestMethod]
    public void LeftEqualsRight() => Assert.IsTrue(Quantity.FromInt32(1) <= Quantity.FromInt32(1));

    [TestMethod]
    public void LeftIsGreaterThanRight() => Assert.IsFalse(Quantity.FromInt32(1) <= Quantity.Zero);

    [TestMethod]
    public void LeftIsLessThanRight() => Assert.IsTrue(Quantity.Zero <= Quantity.FromInt32(1));
}
