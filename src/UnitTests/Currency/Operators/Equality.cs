using Common;

namespace CurrencyTests.Operators;

[TestClass]
public class Equality
{
    [TestMethod]
    public void LeftDoesNotEqualRight() => Assert.IsFalse(Currency.Unknown == Currency.Parse("AAA"));

    [TestMethod]
    public void LeftEqualsRight() => Assert.IsTrue(Currency.Parse("AAA") == Currency.Parse("AAA"));
}
