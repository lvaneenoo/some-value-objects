using Common;

namespace NameTests.WhenDeterminingEquality;

[TestClass]
public class BetweenUnknownAndDefault
{
    [TestMethod]
    public void ShouldReturnTrue() => Assert.IsTrue(Name.Unknown.Equals(new Name()));
}
