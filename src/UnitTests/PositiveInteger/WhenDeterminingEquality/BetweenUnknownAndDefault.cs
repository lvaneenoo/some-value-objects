using Common;

namespace PositiveIntegerTests.WhenDeterminingEquality;

[TestClass]
public class BetweenUnknownAndDefault
{
    [TestMethod]
    public void ShouldReturnTrue() => Assert.IsTrue(PositiveInteger.Unknown.Equals(new PositiveInteger()));
}
