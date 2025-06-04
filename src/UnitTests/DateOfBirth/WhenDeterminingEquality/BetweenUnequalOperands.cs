using Common;

namespace DateOfBirthTests.WhenDeterminingEquality;

[TestClass]
public class BetweenUnequalOperands
{
    [TestMethod]
    public void ShouldReturnFalse()
        => Assert.IsFalse(DateOfBirth.Unknown.Equals(DateOfBirth.FromDateOnly(new DateOnly(1925, 1, 1))));
}
