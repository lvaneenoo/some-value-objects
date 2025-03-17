using Common;

namespace CountryCodeTests.WhenDeterminingEquality;

[TestClass]
public class BetweenUnknownAndDefault
{
    [TestMethod]
    public void ShouldReturnTrue() => Assert.IsTrue(CountryCode.Unknown.Equals(new CountryCode()));
}
