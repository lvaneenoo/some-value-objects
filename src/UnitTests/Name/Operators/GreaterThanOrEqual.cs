using Common;

namespace NameTests.Operators;

[TestClass]
public class GreaterThanOrEqual
{
    [TestMethod]
    public void LeftEqualsRight() => Assert.IsTrue(Name.Parse("A") >= Name.Parse("A"));

    [TestMethod]
    public void LeftIsGreaterThanRight() => Assert.IsTrue(Name.Parse("A") >= Name.Unknown);

    [TestMethod]
    public void LeftIsLessThanRight() => Assert.IsFalse(Name.Unknown >= Name.Parse("A"));
}
