using Common;

namespace CurrencyTests.WhenTryingToParse;

[TestClass]
public class StringThatHasValidFormat
{
    private readonly Currency _result;
    private readonly bool _returnValue;

    public StringThatHasValidFormat()
    {
        _returnValue = Currency.TryParse("AAA", out _result);
    }

    [TestMethod]
    public void ShouldReturnTrue() => Assert.IsTrue(_returnValue);

    [TestMethod]
    public void ShouldSetResult() => Assert.AreEqual(Currency.Parse("AAA"), _result);
}
