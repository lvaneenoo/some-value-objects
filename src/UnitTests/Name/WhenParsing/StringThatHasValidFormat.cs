using Common;

namespace NameTests.WhenParsing;

public class StringThatHasValidFormat
{
    [Theory]
    [InlineData("A")]
    public void ShouldReturnInstance(string s) => Name.Parse(s);
}
