using Common;

namespace QuantityTests.WhenDeterminingEquality;

[TestClass]
public class BetweenUnequalOperands
{
    [TestMethod]
    public void ShouldReturnFalse() => Assert.IsFalse(Quantity.Zero.Equals(Quantity.FromInt32(1)));
}
