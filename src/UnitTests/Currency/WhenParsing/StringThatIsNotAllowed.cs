using Common;

namespace CurrencyTests.WhenParsing;

public class StringThatIsNotAllowed
{
    [Theory]
    [InlineData("AAA")]
    public void ShouldThrowArgumentOutOfRangeException(string s)
        => Assert.Throws<ArgumentOutOfRangeException>(() => Currency.Parse(s));
}
