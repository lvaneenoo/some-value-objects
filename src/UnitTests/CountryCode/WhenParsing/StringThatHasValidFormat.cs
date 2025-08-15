using Common;

namespace CountryCodeTests.WhenParsing;

public class StringThatHasValidFormat
{
    [Theory]
    [InlineData("AA")]
    public void ShouldReturnInstance(string s)
    {
        _ = CountryCode.Parse(s);
    }
}
