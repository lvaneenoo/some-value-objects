using Common;

namespace CountryCodeTests.WhenParsing;

public class StringThatHasInvalidFormat
{
    [Theory]
    [InlineData("")]
    [InlineData("00")]
    [InlineData("aa")]
    [InlineData("AAA")]
    public void ShouldThrowFormatException(string s)
    {
        Assert.Throws<FormatException>(() => _ = CountryCode.Parse(s));
    }
}
