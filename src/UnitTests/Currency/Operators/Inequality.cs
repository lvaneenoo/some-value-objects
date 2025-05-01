using Common;

namespace CurrencyTests.Operators;

[TestClass]
public class Inequality
{
    [TestMethod]
    public void LeftDoesNotEqualRight() => Assert.IsTrue(Currency.Unknown != Currency.Parse("AAA"));

    [TestMethod]
    public void LeftEqualsRight() => Assert.IsFalse(Currency.Parse("AAA") != Currency.Parse("AAA"));
}
