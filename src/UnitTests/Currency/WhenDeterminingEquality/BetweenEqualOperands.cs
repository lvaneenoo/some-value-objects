using Common;

namespace CurrencyTests.WhenDeterminingEquality;

public class BetweenEqualOperands
{
    [Theory]
    [InlineData("EUR", "EUR")]
    public void ShouldReturnTrue(string s1, string s2)
    {
        var sut = Currency.Parse(s1);

        Assert.True(sut.Equals(Currency.Parse(s2)));
    }
}
