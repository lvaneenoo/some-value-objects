using Common;

namespace NameTests.Operators;

[TestClass]
public class LessThan
{
    [TestMethod]
    public void LeftEqualsRight() => Assert.IsFalse(Name.Parse("A") < Name.Parse("A"));

    [TestMethod]
    public void LeftIsGreaterThanRight() => Assert.IsFalse(Name.Parse("A") < Name.Unknown);

    [TestMethod]
    public void LeftIsLessThanRight() => Assert.IsTrue(Name.Unknown < Name.Parse("A"));
}
