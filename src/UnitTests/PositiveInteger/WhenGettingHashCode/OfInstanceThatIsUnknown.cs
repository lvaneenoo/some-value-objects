using Common;

namespace PositiveIntegerTests.WhenGettingHashCode;

[TestClass]
public class OfInstanceThatIsUnknown
{
    [TestMethod]
    public void ShouldReturnZero() => Assert.AreEqual(0, PositiveInteger.Unknown.GetHashCode());
}
