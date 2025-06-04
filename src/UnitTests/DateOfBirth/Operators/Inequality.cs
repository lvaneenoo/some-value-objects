using Common;

namespace DateOfBirthTests.Operators;

[TestClass]
public class Inequality
{
    [TestMethod]
    public void LeftDoesNotEqualRight()
        => Assert.IsTrue(DateOfBirth.Unknown != DateOfBirth.FromDateOnly(new DateOnly(1925, 1, 1)));

    [TestMethod]
    public void LeftEqualsRight()
        => Assert.IsFalse(DateOfBirth.FromDateOnly(new DateOnly(1925, 1, 1)) !=
                          DateOfBirth.FromDateOnly(new DateOnly(1925, 1, 1)));
}
