using Common;

namespace PositiveIntegerTests.WhenComparingTo;

[TestClass]
public class InstanceThatIsLess
{
    private readonly int _returnValue;

    public InstanceThatIsLess()
    {
        var sut = PositiveInteger.FromInt32(1);

        _returnValue = sut.CompareTo(PositiveInteger.Unknown);
    }

    [TestMethod]
    public void ShouldReturnOne()
    {
        Assert.AreEqual(1, _returnValue);
    }
}
