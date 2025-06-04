using Common;

namespace DateOfBirthTests.Operators;

[TestClass]
public class Equality
{
    [TestMethod]
    public void LeftDoesNotEqualRight()
        => Assert.IsFalse(DateOfBirth.Unknown == DateOfBirth.FromDateOnly(new DateOnly(1925, 1, 1)));

    [TestMethod]
    public void LeftEqualsRight()
        => Assert.IsTrue(DateOfBirth.FromDateOnly(new DateOnly(1925, 1, 1)) ==
                         DateOfBirth.FromDateOnly(new DateOnly(1925, 1, 1)));
}
