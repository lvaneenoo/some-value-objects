using Common;

namespace CountryCodeTests.WhenDeterminingEquality;

public class BetweenUnequalOperands
{
    [Theory]
    [InlineData("AA", "AB")]
    public void ShouldReturnFalse(string s1, string s2)
    {
        var sut = CountryCode.Parse(s1);

        Assert.False(sut.Equals(CountryCode.Parse(s2)));
    }
}
