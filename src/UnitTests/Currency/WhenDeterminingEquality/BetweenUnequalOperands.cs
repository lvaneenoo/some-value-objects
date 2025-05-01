using Common;

namespace CurrencyTests.WhenDeterminingEquality;

[TestClass]
public class BetweenUnequalOperands
{
    [TestMethod]
    public void ShouldReturnFalse() => Assert.IsFalse(Currency.Unknown.Equals(Currency.Parse("AAA")));
}
