using Common;

namespace CurrencyTests.WhenComparingTo;

[TestClass]
public class InstanceThatIsEqual
{
    [TestMethod]
    public void ShouldReturnZero() => Assert.AreEqual(0, Currency.Unknown.CompareTo(Currency.Unknown));
}
