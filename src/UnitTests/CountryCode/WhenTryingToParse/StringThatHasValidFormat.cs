using Common;

namespace CountryCodeTests.WhenTryingToParse;

public class StringThatHasValidFormat
{
    [Theory]
    [InlineData("AA")]
    public void ShouldCreateResult(string s)
    {
        Assert.True(CountryCode.TryParse(s, out CountryCode? result));
        Assert.NotNull(result);
    }
}
