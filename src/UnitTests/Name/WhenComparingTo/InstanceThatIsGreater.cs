using Common;

namespace NameTests.WhenComparingTo;

[TestClass]
public class InstanceThatIsGreater
{
    [TestMethod]
    public void ShouldReturnMinusOne() => Assert.AreEqual(-1, Name.Unknown.CompareTo(Name.Parse("A")));
}
