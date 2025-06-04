using Common;

namespace DateOfBirthTests.Operators;

[TestClass]
public class GreaterThanOrEqual
{
    [TestMethod]
    public void LeftEqualsRight()
        => Assert.IsTrue(DateOfBirth.FromDateOnly(new DateOnly(1925, 1, 1)) >=
                         DateOfBirth.FromDateOnly(new DateOnly(1925, 1, 1)));

    [TestMethod]
    public void LeftIsGreaterThanRight()
        => Assert.IsTrue(DateOfBirth.FromDateOnly(new DateOnly(1925, 1, 1)) >= DateOfBirth.Unknown);

    [TestMethod]
    public void LeftIsLessThanRight()
        => Assert.IsFalse(DateOfBirth.Unknown >= DateOfBirth.FromDateOnly(new DateOnly(1925, 1, 1)));
}
