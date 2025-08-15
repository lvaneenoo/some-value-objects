using Common;

namespace NameTests.WhenComparingTo;

public class InstanceThatIsGreater
{
    [Theory]
    [InlineData("A", "B")]
    public void ShouldReturnMinusOne(string s1, string s2)
    {
        var sut = Name.Parse(s1);

        Assert.Equal(-1, sut.CompareTo(Name.Parse(s2)));
    }
}
