using Common;

namespace NameTests.Operators;

[TestClass]
public class GreaterThan
{
    [TestMethod]
    public void LeftEqualsRight() => Assert.IsFalse(Name.Parse("A") > Name.Parse("A"));

    [TestMethod]
    public void LeftIsGreaterThanRight() => Assert.IsTrue(Name.Parse("A") > Name.Unknown);

    [TestMethod]
    public void LeftIsLessThanRight() => Assert.IsFalse(Name.Unknown > Name.Parse("A"));
}
