using Common;

namespace NameTests.WhenTryingToParse;

[TestClass]
public class StringThatIsTooLong
{
    private readonly Name _result;
    private readonly bool _returnValue;

    public StringThatIsTooLong()
    {
        _returnValue = Name.TryParse(new string('A', 51), out _result);
    }

    [TestMethod]
    public void ShouldNotSetResult() => Assert.AreEqual(Name.Unknown, _result);

    [TestMethod]
    public void ShouldReturnFalse() => Assert.IsFalse(_returnValue);
}
