using Common;

namespace PositiveIntegerTests.WhenTryingToParse;

[TestClass]
public class StringThatRepresentsValidNumber
{
    private readonly PositiveInteger _result;
    private readonly bool _returnValue;

    public StringThatRepresentsValidNumber()
    {
        _returnValue = PositiveInteger.TryParse("1", out _result);
    }

    [TestMethod]
    public void ShouldReturnTrue() => Assert.IsTrue(_returnValue);

    [TestMethod]
    public void ShouldSetResult() => Assert.AreEqual(PositiveInteger.FromInt32(1), _result);
}
