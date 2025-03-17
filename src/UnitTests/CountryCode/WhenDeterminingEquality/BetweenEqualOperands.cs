using Common;

namespace CountryCodeTests.WhenDeterminingEquality;

[TestClass]
public class BetweenEqualOperands
{
    [TestMethod]
    public void ShouldReturnTrue() => Assert.IsTrue(CountryCode.Unknown.Equals(CountryCode.Unknown));
}
