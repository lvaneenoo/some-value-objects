using Common;

namespace CountryCodeTests.WhenConvertingToString;

[TestClass]
public class InstanceThatIsNotUnknown
{
    private readonly string _returnValue;
    private readonly string _value;

    public InstanceThatIsNotUnknown()
    {
        _value = "AA";
        var sut = CountryCode.Parse(_value);

        _returnValue = sut.ToString();
    }

    [TestMethod]
    public void ShouldReturnValue() => Assert.AreEqual(_value, _returnValue);
}
