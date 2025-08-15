using Common;

namespace CurrencyTests.WhenComparingTo;

public class InstanceThatIsLess
{
    [Theory]
    [InlineData("GBP", "EUR")]
    public void ShouldReturnOne(string s1, string s2)
    {
        var sut = Currency.Parse(s1);

        Assert.Equal(1, sut.CompareTo(Currency.Parse(s2)));
    }
}
