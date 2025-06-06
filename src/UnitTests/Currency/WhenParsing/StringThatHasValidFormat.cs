using Common;

namespace CurrencyTests.WhenParsing;

public class StringThatHasValidFormat
{
    [Theory]
    [InlineData("AAA")]
    public void ShouldReturnInstance(string s)
    {
        Currency sut = Currency.Parse(s);

        Assert.Equal(s.GetHashCode(), sut.GetHashCode());
        Assert.Equal(s, sut.ToString());
    }
}
