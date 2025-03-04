using Common;

namespace CountryCodeTests.WhenTryingToParse;

[TestClass]
public class StringThatHasValidFormat
{
    private readonly CountryCode _result;
    private readonly bool _returnValue;

    public StringThatHasValidFormat()
    {
        _returnValue = CountryCode.TryParse("AA", out _result);
    }

    [TestMethod]
    public void ShouldReturnTrue()
    {
        Assert.IsTrue(_returnValue);
    }

    [TestMethod]
    public void ShouldSetResult()
    {
        Assert.AreNotEqual(CountryCode.Unknown, _result);
    }
}
