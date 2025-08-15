using Common;

namespace CountryCodeTests.WhenDeterminingEquality;

public class BetweenEqualOperands
{
    [Theory]
    [InlineData("AA", "AA")]
    public void ShouldReturnTrue(string s1, string s2)
    {
        var sut = CountryCode.Parse(s1);

        Assert.True(sut.Equals(CountryCode.Parse(s2)));
    }
}
