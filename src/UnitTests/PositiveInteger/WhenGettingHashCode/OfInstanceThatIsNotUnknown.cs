using Common;

namespace PositiveIntegerTests.WhenGettingHashCode;

[TestClass]
public class OfInstanceThatIsNotUnknown
{
    private readonly int _returnValue;
    private readonly int _value;

    public OfInstanceThatIsNotUnknown()
    {
        _value = 1;
        var sut = PositiveInteger.FromInt32(_value);

        _returnValue = sut.GetHashCode();
    }

    [TestMethod]
    public void ShouldReturnHashCode()
    {
        Assert.AreEqual(_value.GetHashCode(), _returnValue);
    }
}
