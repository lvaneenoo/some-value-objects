using Common;

namespace CurrencyTests.WhenGettingHashCode;

[TestClass]
public class OfInstanceThatIsUnknown
{
    [TestMethod]
    public void ShouldReturnHashCode() => Assert.AreEqual(0, Currency.Unknown.GetHashCode());
}
