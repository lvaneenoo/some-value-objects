using Common;

namespace CountryCodeTests.WhenGettingHashCode;

[TestClass]
public class OfInstanceThatIsUnknown
{
    private readonly int _returnValue;

    public OfInstanceThatIsUnknown()
    {
        _returnValue = CountryCode.Unknown.GetHashCode();
    }

    [TestMethod]
    public void ShouldReturnHashCode()
    {
        Assert.AreEqual(0, _returnValue);
    }
}
