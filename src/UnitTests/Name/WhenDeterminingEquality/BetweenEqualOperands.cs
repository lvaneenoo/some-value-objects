using Common;

namespace NameTests.WhenDeterminingEquality;

public class BetweenEqualOperands
{
    [Theory]
    [InlineData("A", "A")]
    public void ShouldReturnTrue(string s1, string s2)
    {
        var sut = Name.Parse(s1);

        Assert.True(sut.Equals(Name.Parse(s2)));
    }
}
