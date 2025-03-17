using Common;

namespace NameTests.WhenComparingTo;

[TestClass]
public class InstanceThatIsLess
{
    private readonly int _returnValue;

    public InstanceThatIsLess()
    {
        var sut = Name.Parse("A");

        _returnValue = sut.CompareTo(Name.Unknown);
    }

    [TestMethod]
    public void ShouldReturnOne() => Assert.AreEqual(1, _returnValue);
}
