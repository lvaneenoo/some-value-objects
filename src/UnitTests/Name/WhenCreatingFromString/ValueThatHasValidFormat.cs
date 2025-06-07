using Common;

namespace NameTests.WhenCreatingFromString;

public class ValueThatHasValidFormat
{
    [Theory]
    [InlineData("A")]
    public void ShouldReturnInstance(string s)
    {
        Name sut = Name.FromString(s);

        Assert.Equal(s.GetHashCode(), sut.GetHashCode());
        Assert.Equal(s, sut.ToString());
    }
}
