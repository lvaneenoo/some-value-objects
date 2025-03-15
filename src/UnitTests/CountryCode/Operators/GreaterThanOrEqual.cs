using Common;

namespace CountryCodeTests.Operators;

[TestClass]
public class GreaterThanOrEqual
{
    [TestMethod]
    public void LeftEqualsRight() => Assert.IsTrue(CountryCode.Parse("AA") >= CountryCode.Parse("AA"));

    [TestMethod]
    public void LeftIsGreaterThanRight() => Assert.IsTrue(CountryCode.Parse("AA") >= CountryCode.Unknown);

    [TestMethod]
    public void LeftIsLessThanRight() => Assert.IsFalse(CountryCode.Unknown >= CountryCode.Parse("AA"));
}
