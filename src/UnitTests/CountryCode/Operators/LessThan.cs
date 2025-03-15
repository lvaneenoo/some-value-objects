using Common;

namespace CountryCodeTests.Operators;

[TestClass]
public class LessThan
{
    [TestMethod]
    public void LeftEqualsRight() => Assert.IsFalse(CountryCode.Parse("AA") < CountryCode.Parse("AA"));

    [TestMethod]
    public void LeftIsGreaterThanRight() => Assert.IsFalse(CountryCode.Parse("AA") < CountryCode.Unknown);

    [TestMethod]
    public void LeftIsLessThanRight() => Assert.IsTrue(CountryCode.Unknown < CountryCode.Parse("AA"));
}
