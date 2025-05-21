using Common;

namespace FractionalQuantityTests.WhenDeterminingEquality;

[TestClass]
public class BetweenUnequalOperands
{
    [TestMethod]
    public void ShouldReturnFalse()
        => Assert.IsFalse(FractionalQuantity.Zero.Equals(FractionalQuantity.FromDecimal(0.1M)));
}
