using Common;

namespace NameTests.WhenGettingHashCode;

[TestClass]
public class OfInstanceThatIsNotUnknown
{
    private readonly int _returnValue;
    private readonly string _value;

    public OfInstanceThatIsNotUnknown()
    {
        _value = "A";
        var sut = Name.Parse(_value);

        _returnValue = sut.GetHashCode();
    }

    [TestMethod]
    public void ShouldReturnHashCode() => Assert.AreEqual(_value.GetHashCode(), _returnValue);
}
