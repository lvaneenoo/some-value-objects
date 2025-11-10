using Common;

namespace NameTests.WhenComparingTo;

public class InstanceThatIsEqual
{
    [Theory]
    [InlineData("A", "A")]
    public void ShouldReturnZero(string s1, string s2)
    {
        var sut = Name.Parse(s1, null);

        Assert.Equal(0, sut.CompareTo(Name.Parse(s2,  null)));
    }
}
