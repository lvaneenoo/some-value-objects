using Common;

namespace CurrencyTests.WhenTryingToParse;

public class StringThatHasInvalidFormat
{
    [Theory]
    [InlineData("")]
    [InlineData("000")]
    [InlineData("AAAA")]
    public void ShouldNotCreateResult(string s)
    {
        Assert.False(Currency.TryParse(s, null, out Currency? result));
        Assert.Null(result);
    }
}
