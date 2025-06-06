using Common;

namespace CurrencyTests.WhenParsing;

public class StringThatHasInvalidFormat
{
    [Theory]
    [InlineData("")]
    public void ShouldThrowFormatException(string s)
    {
        Assert.Throws<FormatException>(() => _ = Currency.Parse(s));
    }
}
