using Common;

namespace FractionalQuantityTests.WhenGettingHashCode;

[TestClass]
public class OfInstanceThatIsNotZero
{
    private readonly decimal _value;
    private readonly int _returnValue;

    public OfInstanceThatIsNotZero()
    {
        _value = 0.1M;
        var sut = FractionalQuantity.FromDecimal(_value);

        _returnValue = sut.GetHashCode();
    }

    [TestMethod]
    public void ShouldReturnHashCode() => Assert.AreEqual(_value.GetHashCode(), _returnValue);
}
