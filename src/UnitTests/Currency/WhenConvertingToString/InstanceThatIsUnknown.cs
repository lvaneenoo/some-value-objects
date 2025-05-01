using Common;

namespace CurrencyTests.WhenConvertingToString;

[TestClass]
public class InstanceThatIsUnknown
{
    [TestMethod]
    public void ShouldReturnUnknown() => Assert.AreEqual("Unknown", Currency.Unknown.ToString());
}
