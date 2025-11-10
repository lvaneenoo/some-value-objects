using Common;

namespace CountryCodeTests.WhenTryingToParse;

public class StringThatHasInvalidFormat
{
    [Theory]
    [InlineData("")]
    [InlineData("00")]
    [InlineData("aa")]
    [InlineData("AAA")]
    public void ShouldNotCreateResult(string s)
    {
        Assert.False(CountryCode.TryParse(s, null, out CountryCode? result));
        Assert.Null(result);
    }
}
