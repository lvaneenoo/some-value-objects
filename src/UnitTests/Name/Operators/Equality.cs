using Common;

namespace NameTests.Operators;

[TestClass]
public class Equality
{
    [TestMethod]
    public void LeftDoesNotEqualRight() => Assert.IsFalse(Name.Unknown == Name.Parse("A"));

    [TestMethod]
    public void LeftEqualsRight() => Assert.IsTrue(Name.Parse("A") == Name.Parse("A"));
}
