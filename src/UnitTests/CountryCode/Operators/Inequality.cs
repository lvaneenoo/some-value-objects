using Common;

namespace CountryCodeTests.Operators;

[TestClass]
public class Inequality
{
    [TestMethod]
    public void LeftDoesNotEqualRight() => Assert.IsTrue(CountryCode.Unknown != CountryCode.Parse("AA"));

    [TestMethod]
    public void LeftEqualsRight() => Assert.IsFalse(CountryCode.Parse("AA") != CountryCode.Parse("AA"));
}
