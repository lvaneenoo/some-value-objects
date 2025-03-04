using Common;

namespace CountryCodeTests.WhenTryingToParse;

[TestClass]
public class StringThatHasInvalidFormat
{
    private readonly CountryCode _result;
    private readonly bool _returnValue;

    public StringThatHasInvalidFormat()
    {
        _returnValue = CountryCode.TryParse("", out _result);
    }

    [TestMethod]
    public void ShouldNotSetResult()
    {
        Assert.AreEqual(CountryCode.Unknown, _result);
    }

    [TestMethod]
    public void ShouldReturnFalse()
    {
        Assert.IsFalse(_returnValue);
    }
}
