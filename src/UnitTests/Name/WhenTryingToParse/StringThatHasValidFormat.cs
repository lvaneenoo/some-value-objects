using Common;

namespace NameTests.WhenTryingToParse;

[TestClass]
public class StringThatHasValidFormat
{
    private readonly Name _result;
    private readonly bool _returnValue;

    public StringThatHasValidFormat()
    {
        _returnValue = Name.TryParse("A", out _result);
    }

    [TestMethod]
    public void ShouldReturnTrue() => Assert.IsTrue(_returnValue);

    [TestMethod]
    public void ShouldSetResult() => Assert.AreEqual(Name.Parse("A"), _result);
}
