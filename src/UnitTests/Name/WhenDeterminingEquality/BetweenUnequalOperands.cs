using Common;

namespace NameTests.WhenDeterminingEquality;

public class BetweenUnequalOperands
{
    [Theory]
    [InlineData("A", "B")]
    public void ShouldReturnFalse(string s1, string s2)
    {
        var sut = Name.Parse(s1);

        Assert.False(sut.Equals(Name.Parse(s2)));
    }
}
