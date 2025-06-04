using Common;

namespace DateOfBirthTests.WhenConvertingToString;

[TestClass]
public class InstanceThatIsUnknown
{
    [TestMethod]
    public void ShouldReturnUnknown() => Assert.AreEqual("Unknown", DateOfBirth.Unknown.ToString());
}
