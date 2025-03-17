using Common;

namespace QuantityTests.WhenDeterminingEquality;

[TestClass]
public class BetweenEqualOperands
{
    [TestMethod]
    public void ShouldReturnTrue() => Assert.IsTrue(Quantity.Zero.Equals(Quantity.Zero));
}
