using Common;

namespace CountryCodeTests.WhenDeterminingEquality;

[TestClass]
public class BetweenUnequalOperands
{
    [TestMethod]
    public void ShouldReturnFalse() => Assert.IsFalse(CountryCode.Unknown.Equals(CountryCode.Parse("AA")));
}
