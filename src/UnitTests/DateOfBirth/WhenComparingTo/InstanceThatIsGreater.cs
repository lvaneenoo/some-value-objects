using Common;

namespace DateOfBirthTests.WhenComparingTo;

[TestClass]
public class InstanceThatIsGreater
{
    [TestMethod]
    public void ShouldReturnMinusOne()
        => Assert.AreEqual(-1, DateOfBirth.Unknown.CompareTo(DateOfBirth.FromDateOnly(new DateOnly(1925, 1, 1))));
}
