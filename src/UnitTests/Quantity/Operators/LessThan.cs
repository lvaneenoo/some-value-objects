using Common;

namespace QuantityTests.Operators;

[TestClass]
public class LessThan
{
    [TestMethod]
    public void LeftEqualsRight() => Assert.IsFalse(Quantity.FromInt32(1) < Quantity.FromInt32(1));

    [TestMethod]
    public void LeftIsGreaterThanRight() => Assert.IsFalse(Quantity.FromInt32(1) < Quantity.Zero);

    [TestMethod]
    public void LeftIsLessThanRight() => Assert.IsTrue(Quantity.Zero < Quantity.FromInt32(1));
}
