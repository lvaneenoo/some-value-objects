using Common;

namespace NameTests.WhenComparingTo;

public class InstanceThatIsLess
{
    [Theory]
    [InlineData("B", "A")]
    public void ShouldReturnOne(string s1, string s2)
    {
        var sut = Name.Parse(s1);

        Assert.Equal(1, sut.CompareTo(Name.Parse(s2)));
    }
}
