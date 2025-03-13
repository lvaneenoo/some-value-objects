using Common;

namespace PositiveIntegerTests.WhenConvertingToString;

[TestClass]
public class InstanceThatIsUnknown
{
    [TestMethod]
    public void ShouldReturnUnknown() => Assert.AreEqual("Unknown", PositiveInteger.Unknown.ToString());
}
