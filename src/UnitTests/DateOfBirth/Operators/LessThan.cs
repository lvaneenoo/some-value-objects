using Common;

namespace DateOfBirthTests.Operators;

[TestClass]
public class LessThan
{
    [TestMethod]
    public void LeftEqualsRight()
        => Assert.IsFalse(DateOfBirth.FromDateOnly(new DateOnly(1925, 1, 1)) <
                          DateOfBirth.FromDateOnly(new DateOnly(1925, 1, 1)));

    [TestMethod]
    public void LeftIsGreaterThanRight()
        => Assert.IsFalse(DateOfBirth.FromDateOnly(new DateOnly(1925, 1, 1)) < DateOfBirth.Unknown);

    [TestMethod]
    public void LeftIsLessThanRight()
        => Assert.IsTrue(DateOfBirth.Unknown < DateOfBirth.FromDateOnly(new DateOnly(1925, 1, 1)));
}
