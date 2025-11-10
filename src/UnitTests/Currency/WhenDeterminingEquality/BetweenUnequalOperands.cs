using Common;

namespace CurrencyTests.WhenDeterminingEquality;

public class BetweenUnequalOperands
{
    [Theory]
    [InlineData("EUR", "GBP")]
    public void ShouldReturnFalse(string s1, string s2)
    {
        var sut = Currency.Parse(s1, null);

        Assert.False(sut.Equals(Currency.Parse(s2, null)));
    }
}
