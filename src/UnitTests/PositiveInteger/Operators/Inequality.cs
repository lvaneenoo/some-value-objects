using Common;

namespace PositiveIntegerTests.Operators;

[TestClass]
public class Inequality
{
    [TestMethod]
    public void LeftDoesNotEqualRight() => Assert.IsTrue(PositiveInteger.Unknown != PositiveInteger.FromInt32(1));

    [TestMethod]
    public void LeftEqualsRight() => Assert.IsFalse(PositiveInteger.FromInt32(1) != PositiveInteger.FromInt32(1));
}
