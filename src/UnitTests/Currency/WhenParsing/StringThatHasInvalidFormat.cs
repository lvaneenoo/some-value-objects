using Common;

namespace CurrencyTests.WhenParsing;

public class StringThatHasInvalidFormat
{
    [Theory]
    [InlineData("")]
    [InlineData("000")]
    [InlineData("AAAA")]
    public void ShouldThrowFormatException(string s)
    {
        Assert.Throws<FormatException>(() => _ = Currency.Parse(s));
    }
}
