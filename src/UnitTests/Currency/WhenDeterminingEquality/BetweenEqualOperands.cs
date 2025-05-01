using Common;

namespace CurrencyTests.WhenDeterminingEquality;

[TestClass]
public class BetweenEqualOperands
{
    [TestMethod]
    public void ShouldReturnTrue() => Assert.IsTrue(Currency.Unknown.Equals(Currency.Unknown));
}
