using Common;

namespace DateOfBirthTests.WhenGettingHashCode;

[TestClass]
public class OfInstanceThatIsUnknown
{
    [TestMethod]
    public void ShouldReturnHashCode() => Assert.AreEqual(0, DateOfBirth.Unknown.GetHashCode());
}
