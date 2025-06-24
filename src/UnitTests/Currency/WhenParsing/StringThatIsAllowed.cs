using Common;

namespace CurrencyTests.WhenParsing;

public class StringThatIsAllowed
{
    [Theory]
    [InlineData("EUR")]
    public void ShouldReturnInstance(string s) => Currency.Parse(s);
}
