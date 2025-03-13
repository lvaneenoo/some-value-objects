using Common;

namespace CountryCodeTests.WhenGettingHashCode;

[TestClass]
public class OfInstanceThatIsUnknown
{
    [TestMethod]
    public void ShouldReturnHashCode() => Assert.AreEqual(0, CountryCode.Unknown.GetHashCode());
}
