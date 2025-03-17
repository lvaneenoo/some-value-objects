using Common;

namespace NameTests.WhenDeterminingEquality;

[TestClass]
public class BetweenUnequalOperands
{
    [TestMethod]
    public void ShouldReturnFalse() => Assert.IsFalse(Name.Unknown.Equals(Name.Parse("A")));
}
