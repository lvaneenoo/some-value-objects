using Common;

namespace NameTests.WhenTryingToParse;

[TestClass]
public class StringThatIsEmpty
{
    private readonly Name _result;
    private readonly bool _returnValue;

    public StringThatIsEmpty()
    {
        _returnValue = Name.TryParse("", out _result);
    }

    [TestMethod]
    public void ShouldNotSetResult() => Assert.AreEqual(Name.Unknown, _result);

    [TestMethod]
    public void ShouldReturnFalse() => Assert.IsFalse(_returnValue);
}
