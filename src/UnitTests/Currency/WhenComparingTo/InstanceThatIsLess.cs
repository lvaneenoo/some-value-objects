using Common;

namespace CurrencyTests.WhenComparingTo;

[TestClass]
public class InstanceThatIsLess
{
    private readonly int _returnValue;

    public InstanceThatIsLess()
    {
        var sut = Currency.Parse("AAA");

        _returnValue = sut.CompareTo(Currency.Unknown);
    }

    [TestMethod]
    public void ShouldReturnOne() => Assert.AreEqual(1, _returnValue);
}
