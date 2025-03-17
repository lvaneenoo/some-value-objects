using Common;

namespace CountryCodeTests.WhenComparingTo;

[TestClass]
public class InstanceThatIsEqual
{
    [TestMethod]
    public void ShouldReturnZero() => Assert.AreEqual(0, CountryCode.Unknown.CompareTo(CountryCode.Unknown));
}
