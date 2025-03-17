using Common;

namespace CountryCodeTests.WhenComparingTo;

[TestClass]
public class InstanceThatIsGreater
{
    [TestMethod]
    public void ShouldReturnMinusOne() => Assert.AreEqual(-1, CountryCode.Unknown.CompareTo(CountryCode.Parse("AA")));
}
