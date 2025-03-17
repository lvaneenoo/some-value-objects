using Common;

namespace CountryCodeTests.WhenParsing;

[TestClass]
public class StringThatHasValidFormat
{
    [TestMethod]
    public void ShouldReturnInstance() => Assert.IsNotNull(CountryCode.Parse("AA"));
}
