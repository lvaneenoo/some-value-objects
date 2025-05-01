using Common;

namespace CurrencyTests.WhenParsing;

[TestClass]
public class StringThatHasValidFormat
{
    [TestMethod]
    public void ShouldReturnInstance() => Assert.IsNotNull(Currency.Parse("AAA"));
}
