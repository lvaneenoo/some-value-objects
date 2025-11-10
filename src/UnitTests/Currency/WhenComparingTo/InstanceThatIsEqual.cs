using Common;

namespace CurrencyTests.WhenComparingTo;

public class InstanceThatIsEqual
{
    [Theory]
    [InlineData("EUR", "EUR")]
    public void ShouldReturnZero(string s1, string s2)
    {
        var sut = Currency.Parse(s1, null);

        Assert.Equal(0, sut.CompareTo(Currency.Parse(s2, null)));
    }
}
