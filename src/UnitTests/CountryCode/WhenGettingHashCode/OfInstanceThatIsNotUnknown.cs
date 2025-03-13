using Common;

namespace CountryCodeTests.WhenGettingHashCode;

[TestClass]
public class OfInstanceThatIsNotUnknown
{
    private readonly int _returnValue;
    private readonly string _value;

    public OfInstanceThatIsNotUnknown()
    {
        _value = "AA";
        var sut = CountryCode.Parse(_value);

        _returnValue = sut.GetHashCode();
    }

    [TestMethod]
    public void ShouldReturnHashCode() => Assert.AreEqual(_value.GetHashCode(), _returnValue);
}
