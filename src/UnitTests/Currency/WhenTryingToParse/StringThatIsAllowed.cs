using Common;

namespace CurrencyTests.WhenTryingToParse;

public class StringThatIsAllowed
{
    [Theory]
    [InlineData("EUR")]
    public void ShouldCreateResult(string s)
    {
        Assert.True(Currency.TryParse(s, out Currency? result));
        Assert.NotNull(result);
    }
}
