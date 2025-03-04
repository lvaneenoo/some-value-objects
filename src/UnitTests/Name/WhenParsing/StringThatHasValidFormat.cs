using Common;

namespace NameTests.WhenParsing;

[TestClass]
public class StringThatHasValidFormat
{
    private readonly Name _sut;

    public StringThatHasValidFormat()
    {
        _sut = Name.Parse("A");
    }

    [TestMethod]
    public void ShouldReturnInstance()
    {
        Assert.IsNotNull(_sut);
    }
}
