using Common;

namespace PositiveIntegerTests.WhenDeterminingEquality;

[TestClass]
public class BetweenUnequalOperands
{
    [TestMethod]
    public void ShouldReturnFalse() => Assert.IsFalse(PositiveInteger.Unknown.Equals(PositiveInteger.FromInt32(1)));
}
