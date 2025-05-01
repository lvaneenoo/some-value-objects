using Common;

namespace CurrencyTests.Operators;

[TestClass]
public class GreaterThan
{
    [TestMethod]
    public void LeftEqualsRight() => Assert.IsFalse(Currency.Parse("AAA") > Currency.Parse("AAA"));

    [TestMethod]
    public void LeftIsGreaterThanRight() => Assert.IsTrue(Currency.Parse("AAA") > Currency.Unknown);

    [TestMethod]
    public void LeftIsLessThanRight() => Assert.IsFalse(Currency.Unknown > Currency.Parse("AAA"));
}
