using Common;

namespace CountryCodeTests.WhenConvertingToString;

public class Instance
{
    [Fact]
    public void ShouldReturnValue()
    {
        const string value = "AA";
        var sut = CountryCode.Parse(value, null);

        Assert.Equal(value, sut.ToString());
    }
}
