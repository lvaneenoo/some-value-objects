using Common;

namespace NameTests.WhenComparingTo;

[TestClass]
public class InstanceThatIsEqual
{
    [TestMethod]
    public void ShouldReturnZero() => Assert.AreEqual(0, Name.Unknown.CompareTo(Name.Unknown));
}
