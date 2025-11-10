using Common;

namespace CurrencyTests.WhenParsing;

public class StringThatIsAllowed
{
    [Theory]
    [InlineData("EUR")]
    public void ShouldReturnInstance(string s)
    {
        _ = Currency.Parse(s, null);
    }
}
