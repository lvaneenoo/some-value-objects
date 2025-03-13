using Common;

namespace CountryCodeTests.WhenComparingTo;

[TestClass]
public class InstanceThatIsEqual
{
    private readonly int _returnValue;

    public InstanceThatIsEqual()
    {
        var code = CountryCode.Parse("AA");

        _returnValue = code.CompareTo(CountryCode.Parse("AA"));
    }

    [TestMethod]
    public void ShouldReturnZero() => Assert.AreEqual(0, _returnValue);
}
