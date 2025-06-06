using Common;

namespace NameTests.WhenParsing;

public class StringThatHasValidFormat
{
    [Theory]
    [InlineData("A")]
    public void ShouldReturnInstance(string s)
    {
        Name sut = Name.Parse(s);

        Assert.Equal(s.GetHashCode(), sut.GetHashCode());
        Assert.Equal(s, sut.ToString());
    }
}
