using Common;

namespace DateOfBirthTests.WhenComparingTo;

[TestClass]
public class InstanceThatIsEqual
{
    [TestMethod]
    public void ShouldReturnZero() => Assert.AreEqual(0, DateOfBirth.Unknown.CompareTo(DateOfBirth.Unknown));
}
