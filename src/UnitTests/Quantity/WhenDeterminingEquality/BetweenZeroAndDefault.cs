using Common;

namespace QuantityTests.WhenDeterminingEquality;

[TestClass]
public class BetweenZeroAndDefault
{
    [TestMethod]
    public void ShouldReturnTrue()
    {
        Assert.IsTrue(Quantity.Zero.Equals(new Quantity()));
    }
}
