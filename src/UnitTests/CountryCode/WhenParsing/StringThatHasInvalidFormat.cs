using Common;

namespace CountryCodeTests.WhenParsing;

[TestClass]
public class StringThatHasInvalidFormat
{
    private readonly FormatException? _exception;

    public StringThatHasInvalidFormat()
    {
        try
        {
            CountryCode.Parse("");
        }
        catch (FormatException ex)
        {
            _exception = ex;
        }
    }

    [TestMethod]
    public void ShouldThrowFormatException()
    {
        Assert.IsNotNull(_exception);
    }
}
