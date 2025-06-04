using Common;

namespace DateOfBirthTests.WhenDeterminingEquality;

[TestClass]
public class BetweenUnknownAndDefault
{
    [TestMethod]
    public void ShouldReturnTrue() => Assert.IsTrue(DateOfBirth.Unknown.Equals(new DateOfBirth()));
}
