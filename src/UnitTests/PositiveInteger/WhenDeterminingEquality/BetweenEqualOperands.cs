using Common;

namespace PositiveIntegerTests.WhenDeterminingEquality;

[TestClass]
public class BetweenEqualOperands
{
    [TestMethod]
    public void ShouldReturnTrue() => Assert.IsTrue(PositiveInteger.Unknown.Equals(PositiveInteger.Unknown));
}
