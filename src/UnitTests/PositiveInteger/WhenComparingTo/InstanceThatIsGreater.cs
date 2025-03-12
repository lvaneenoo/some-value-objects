using Common;

namespace PositiveIntegerTests.WhenComparingTo;

[TestClass]
public class InstanceThatIsGreater
{
    [TestMethod]
    public void ShouldReturnMinusOne()
    {
        Assert.AreEqual(-1, PositiveInteger.Unknown.CompareTo(PositiveInteger.FromInt32(1)));
    }
}
