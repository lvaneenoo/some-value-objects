using Common;

namespace CountryCodeTests.WhenComparingTo;

public class InstanceThatIsGreater
{
    [Theory]
    [InlineData("AA", "AB")]
    public void ShouldReturnMinusOne(string s1, string s2)
    {
        var sut = CountryCode.Parse(s1);

        Assert.Equal(-1, sut.CompareTo(CountryCode.Parse(s2)));
    }
}
