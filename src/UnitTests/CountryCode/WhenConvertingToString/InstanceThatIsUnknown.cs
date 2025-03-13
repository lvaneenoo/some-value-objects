using Common;

namespace CountryCodeTests.WhenConvertingToString;

[TestClass]
public class InstanceThatIsUnknown
{
    [TestMethod]
    public void ShouldReturnUnknown() => Assert.AreEqual("Unknown", CountryCode.Unknown.ToString());
}
