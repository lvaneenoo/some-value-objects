using Common;

namespace QuantityTests.WhenGettingHashCode;

[TestClass]
public class OfInstanceThatIsNotZero
{
    private readonly int _returnValue;
    private readonly int _value;

    public OfInstanceThatIsNotZero()
    {
        _value = 1;
        var sut = Quantity.FromInt32(_value);

        _returnValue = sut.GetHashCode();
    }

    [TestMethod]
    public void ShouldReturnHashCode() => Assert.AreEqual(_value.GetHashCode(), _returnValue);
}
