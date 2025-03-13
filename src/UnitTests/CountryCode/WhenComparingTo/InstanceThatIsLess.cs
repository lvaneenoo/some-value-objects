using Common;

namespace CountryCodeTests.WhenComparingTo;

[TestClass]
public class InstanceThatIsLess
{
    private readonly int _returnValue;

    public InstanceThatIsLess()
    {
        var code = CountryCode.Parse("AB");

        _returnValue = code.CompareTo(CountryCode.Parse("AA"));
    }

    [TestMethod]
    public void ShouldReturnOne() => Assert.AreEqual(1, _returnValue);
}
