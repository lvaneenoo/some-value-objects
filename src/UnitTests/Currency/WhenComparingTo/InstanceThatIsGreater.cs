using Common;

namespace CurrencyTests.WhenComparingTo;

public class InstanceThatIsGreater
{
    [Theory]
    [InlineData("EUR", "GBP")]
    public void ShouldReturnMinusOne(string s1, string s2)
    {
        var sut = Currency.Parse(s1, null);

        Assert.Equal(-1, sut.CompareTo(Currency.Parse(s2, null)));
    }
}
