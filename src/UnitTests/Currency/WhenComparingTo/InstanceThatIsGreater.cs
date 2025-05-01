using Common;

namespace CurrencyTests.WhenComparingTo;

[TestClass]
public class InstanceThatIsGreater
{
    [TestMethod]
    public void ShouldReturnMinusOne() => Assert.AreEqual(-1, Currency.Unknown.CompareTo(Currency.Parse("AAA")));
}
