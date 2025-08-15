using Common;

namespace CountryCodeTests.WhenComparingTo;

public class InstanceThatIsEqual
{
    [Theory]
    [InlineData("AA", "AA")]
    public void ShouldReturnZero(string s1, string s2)
    {
        var sut = CountryCode.Parse(s1);

        Assert.Equal(0, sut.CompareTo(CountryCode.Parse(s2)));
    }
}
