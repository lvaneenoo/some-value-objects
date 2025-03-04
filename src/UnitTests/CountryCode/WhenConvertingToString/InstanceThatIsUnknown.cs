using Common;

namespace CountryCodeTests.WhenConvertingToString;

[TestClass]
public class InstanceThatIsUnknown
{
    private readonly string _returnValue;

    public InstanceThatIsUnknown()
    {
        _returnValue = CountryCode.Unknown.ToString();
    }

    [TestMethod]
    public void ShouldReturnUnknown()
    {
        Assert.AreEqual("Unknown", _returnValue);
    }
}
