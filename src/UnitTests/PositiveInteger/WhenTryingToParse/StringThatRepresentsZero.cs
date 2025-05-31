using Common;

namespace PositiveIntegerTests.WhenTryingToParse;

[TestClass]
public class StringThatRepresentsZero
{
    private readonly PositiveInteger _result;
    private readonly bool _returnValue;

    public StringThatRepresentsZero()
    {
        _returnValue = PositiveInteger.TryParse("0", out _result);
    }

    [TestMethod]
    public void ShouldNotSetResult() => Assert.AreEqual(PositiveInteger.Unknown, _result);

    [TestMethod]
    public void ShouldReturnFalse() => Assert.IsFalse(_returnValue);
}
