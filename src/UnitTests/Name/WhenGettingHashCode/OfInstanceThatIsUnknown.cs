using Common;

namespace NameTests.WhenGettingHashCode;

[TestClass]
public class OfInstanceThatIsUnknown
{
    [TestMethod]
    public void ShouldReturnHashCode() => Assert.AreEqual(0, Name.Unknown.GetHashCode());
}
