using Common;

namespace NameTests.WhenParsing;

[TestClass]
public class StringThatIsEmpty
{
    private readonly FormatException? _exception;

    public StringThatIsEmpty()
    {
        try
        {
            Name.Parse("");
        }
        catch (FormatException ex)
        {
            _exception = ex;
        }
    }

    [TestMethod]
    public void ShouldThrowFormatException()
    {
        Assert.IsNotNull(_exception);
    }
}
