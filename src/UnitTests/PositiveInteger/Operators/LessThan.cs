using Common;

namespace PositiveIntegerTests.Operators;

[TestClass]
public class LessThan
{
    [TestMethod]
    public void LeftEqualsRight() => Assert.IsFalse(PositiveInteger.FromInt32(1) < PositiveInteger.FromInt32(1));

    [TestMethod]
    public void LeftIsGreaterThanRight() => Assert.IsFalse(PositiveInteger.FromInt32(1) < PositiveInteger.Unknown);

    [TestMethod]
    public void LeftIsLessThanRight() => Assert.IsTrue(PositiveInteger.Unknown < PositiveInteger.FromInt32(1));
}
