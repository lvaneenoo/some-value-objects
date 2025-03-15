using Common;

namespace CountryCodeTests.Operators;

[TestClass]
public class Equality
{
    [TestMethod]
    public void LeftDoesNotEqualRight() => Assert.IsFalse(CountryCode.Unknown == CountryCode.Parse("AA"));

    [TestMethod]
    public void LeftEqualsRight() => Assert.IsTrue(CountryCode.Parse("AA") == CountryCode.Parse("AA"));
}
