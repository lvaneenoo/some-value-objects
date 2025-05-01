using Common;

namespace CurrencyTests.WhenTryingToParse;

[TestClass]
public class StringThatHasInvalidFormat
{
    private readonly Currency _result;
    private readonly bool _returnValue;

    public StringThatHasInvalidFormat()
    {
        _returnValue = Currency.TryParse("", out _result);
    }

    [TestMethod]
    public void ShouldNotSetResult() => Assert.AreEqual(Currency.Unknown, _result);

    [TestMethod]
    public void ShouldReturnFalse() => Assert.IsFalse(_returnValue);
}
