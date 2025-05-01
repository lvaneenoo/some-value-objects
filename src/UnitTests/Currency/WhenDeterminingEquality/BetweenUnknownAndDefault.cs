using Common;

namespace CurrencyTests.WhenDeterminingEquality;

[TestClass]
public class BetweenUnknownAndDefault
{
    [TestMethod]
    public void ShouldReturnTrue() => Assert.IsTrue(Currency.Unknown.Equals(new Currency()));
}
