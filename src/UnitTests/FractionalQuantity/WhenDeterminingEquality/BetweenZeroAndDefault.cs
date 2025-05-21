using Common;

namespace FractionalQuantityTests.WhenDeterminingEquality;

[TestClass]
public class BetweenZeroAndDefault
{
    [TestMethod]
    public void ShouldReturnTrue() => Assert.IsTrue(FractionalQuantity.Zero.Equals(new FractionalQuantity()));
}
