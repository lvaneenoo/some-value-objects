using Common;

namespace CurrencyTests.WhenTryingToParse;

public class StringThatIsNotAllowed
{
    [Theory]
    [InlineData("AAA")]
    public void ShouldNotCreateResult(string s)
    {
        Assert.False(Currency.TryParse(s, out Currency? result));
        Assert.Null(result);
    }
}
