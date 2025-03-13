using Common;

namespace NameTests.WhenParsing;

[TestClass]
public class StringThatIsTooLong
{
    private readonly FormatException? _exception;

    public StringThatIsTooLong()
    {
        try
        {
            Name.Parse(new string('A', 51));
        }
        catch (FormatException ex)
        {
            _exception = ex;
        }
    }

    [TestMethod]
    public void ShouldThrowFormatException() => Assert.IsNotNull(_exception);
}
