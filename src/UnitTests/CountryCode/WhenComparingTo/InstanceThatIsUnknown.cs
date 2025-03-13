using Common;

namespace CountryCodeTests.WhenComparingTo;

[TestClass]
public class InstanceThatIsUnknown
{
    private readonly int _returnValue;

    public InstanceThatIsUnknown()
    {
        var code = CountryCode.Parse("AA");

        _returnValue = code.CompareTo(CountryCode.Unknown);
    }

    [TestMethod]
    public void ShouldReturnOne() => Assert.AreEqual(1, _returnValue);
}
