using Common;

namespace CountryCodeTests.WhenComparingTo;

[TestClass]
public class InstanceThatIsGreater
{
    private readonly int _returnValue;

    public InstanceThatIsGreater()
    {
        var code = CountryCode.Parse("AA");

        _returnValue = code.CompareTo(CountryCode.Parse("AB"));
    }

    [TestMethod]
    public void ShouldReturnMinusOne() => Assert.AreEqual(-1, _returnValue);
}
