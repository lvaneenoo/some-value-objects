using Common;

namespace DateOfBirthTests.WhenDeterminingEquality;

[TestClass]
public class BetweenEqualOperands
{
    [TestMethod]
    public void ShouldReturnTrue() => Assert.IsTrue(DateOfBirth.Unknown.Equals(DateOfBirth.Unknown));
}
