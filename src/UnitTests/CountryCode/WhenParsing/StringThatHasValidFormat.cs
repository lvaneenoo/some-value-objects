using Common;

namespace CountryCodeTests.WhenParsing;

public class StringThatHasValidFormat
{
    [Theory]
    [InlineData("AA")]
    public void ShouldReturnInstance(string s)
    {
        CountryCode sut = CountryCode.Parse(s);

        Assert.Equal(s.GetHashCode(), sut.GetHashCode());
        Assert.Equal(s, sut.ToString());
    }
}
