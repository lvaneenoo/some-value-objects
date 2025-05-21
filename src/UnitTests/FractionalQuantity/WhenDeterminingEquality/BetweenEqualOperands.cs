using Common;

namespace FractionalQuantityTests.WhenDeterminingEquality;

[TestClass]
public class BetweenEqualOperands
{
    [TestMethod]
    public void ShouldReturnTrue() => Assert.IsTrue(FractionalQuantity.Zero.Equals(FractionalQuantity.Zero));
}
