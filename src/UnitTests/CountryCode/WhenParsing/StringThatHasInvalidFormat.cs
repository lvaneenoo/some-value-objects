using Common;

namespace CountryCodeTests.WhenParsing;

public class StringThatHasInvalidFormat
{
    [Theory]
    [InlineData("")]
    public void ShouldThrowFormatException(string s)
    {
        Assert.Throws<FormatException>(() => _ = CountryCode.Parse(s));
    }
}
