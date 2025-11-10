using Common;

namespace CountryCodeTests.WhenGettingHashCode;

public class OfInstance
{
    [Fact]
    public void ShouldReturnHashCode()
    {
        const string value = "AA";
        var sut = CountryCode.Parse(value, null);

        Assert.Equal(value.GetHashCode(), sut.GetHashCode());
    }
}
