using Common;

namespace NameTests.WhenConvertingToString;

[TestClass]
public class InstanceThatIsUnknown
{
    [TestMethod]
    public void ShouldReturnUnknown() => Assert.AreEqual("Unknown", Name.Unknown.ToString());
}
