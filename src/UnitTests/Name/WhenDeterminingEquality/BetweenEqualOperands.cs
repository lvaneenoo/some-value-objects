using Common;

namespace NameTests.WhenDeterminingEquality;

[TestClass]
public class BetweenEqualOperands
{
    [TestMethod]
    public void ShouldReturnTrue() => Assert.IsTrue(Name.Unknown.Equals(Name.Unknown));
}
