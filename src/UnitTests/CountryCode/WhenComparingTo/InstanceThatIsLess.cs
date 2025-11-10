using Common;

namespace CountryCodeTests.WhenComparingTo;

public class InstanceThatIsLess
{
    [Theory]
    [InlineData("AB", "AA")]
    public void ShouldReturnOne(string s1, string s2)
    {
        var sut = CountryCode.Parse(s1, null);

        Assert.Equal(1, sut.CompareTo(CountryCode.Parse(s2, null)));
    }
}
