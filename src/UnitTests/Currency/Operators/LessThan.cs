using Common;

namespace CurrencyTests.Operators;

[TestClass]
public class LessThan
{
    [TestMethod]
    public void LeftEqualsRight() => Assert.IsFalse(Currency.Parse("AAA") < Currency.Parse("AAA"));

    [TestMethod]
    public void LeftIsGreaterThanRight() => Assert.IsFalse(Currency.Parse("AAA") < Currency.Unknown);

    [TestMethod]
    public void LeftIsLessThanRight() => Assert.IsTrue(Currency.Unknown < Currency.Parse("AAA"));
}
