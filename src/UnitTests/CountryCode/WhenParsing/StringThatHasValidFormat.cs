using Common;

namespace CountryCodeTests.WhenParsing;

[TestClass]
public class StringThatHasValidFormat
{
    private readonly CountryCode _sut;

    public StringThatHasValidFormat()
    {
        _sut = CountryCode.Parse("AA");
    }

    [TestMethod]
    public void ShouldReturnInstance() => Assert.IsNotNull(_sut);
}
