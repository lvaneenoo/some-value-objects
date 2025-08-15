using Common;

namespace NameTests.WhenParsing;

public class StringThatHasValidFormat
{
    [Theory]
    [InlineData("A")]
    public void ShouldReturnInstance(string s)
    {
        _ = Name.Parse(s);
    }
}
