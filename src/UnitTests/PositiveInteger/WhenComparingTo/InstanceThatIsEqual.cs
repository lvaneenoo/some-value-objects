using Common;

namespace PositiveIntegerTests.WhenComparingTo;

[TestClass]
public class InstanceThatIsEqual
{
    [TestMethod]
    public void ShouldReturnZero()
    {
        Assert.AreEqual(0, PositiveInteger.Unknown.CompareTo(PositiveInteger.Unknown));
    }
}
