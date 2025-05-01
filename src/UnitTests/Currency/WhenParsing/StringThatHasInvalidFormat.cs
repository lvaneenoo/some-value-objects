using Common;

namespace CurrencyTests.WhenParsing;

[TestClass]
public class StringThatHasInvalidFormat
{
    private readonly FormatException? _exception;

    public StringThatHasInvalidFormat()
    {
        try
        {
            Currency.Parse("");
        }
        catch (FormatException ex)
        {
            _exception = ex;
        }
    }

    [TestMethod]
    public void ShouldThrowFormatException() => Assert.IsNotNull(_exception);
}
