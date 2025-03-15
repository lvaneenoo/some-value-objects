using Common;

namespace NameTests.Operators;

[TestClass]
public class Inequality
{
    [TestMethod]
    public void LeftDoesNotEqualRight() => Assert.IsTrue(Name.Unknown != Name.Parse("A"));

    [TestMethod]
    public void LeftEqualsRight() => Assert.IsFalse(Name.Parse("A") != Name.Parse("A"));
}
