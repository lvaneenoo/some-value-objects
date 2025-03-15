using Common;

namespace PositiveIntegerTests.Operators;

[TestClass]
public class GreaterThan
{
    [TestMethod]
    public void LeftEqualsRight() => Assert.IsFalse(PositiveInteger.FromInt32(1) > PositiveInteger.FromInt32(1));

    [TestMethod]
    public void LeftIsGreaterThanRight() => Assert.IsTrue(PositiveInteger.FromInt32(1) > PositiveInteger.Unknown);

    [TestMethod]
    public void LeftIsLessThanRight() => Assert.IsFalse(PositiveInteger.Unknown > PositiveInteger.FromInt32(1));
}
