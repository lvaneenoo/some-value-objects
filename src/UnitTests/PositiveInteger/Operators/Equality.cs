using Common;

namespace PositiveIntegerTests.Operators;

[TestClass]
public class Equality
{
    [TestMethod]
    public void LeftDoesNotEqualRight() => Assert.IsFalse(PositiveInteger.Unknown == PositiveInteger.FromInt32(1));

    [TestMethod]
    public void LeftEqualsRight() => Assert.IsTrue(PositiveInteger.FromInt32(1) == PositiveInteger.FromInt32(1));
}
