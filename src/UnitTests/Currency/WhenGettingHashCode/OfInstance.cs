using Common;

namespace CurrencyTests.WhenGettingHashCode;

public class OfInstance
{
    [Fact]
    public void ShouldReturnHashCode()
    {
        const string value = "EUR";
        var sut = Currency.Parse(value, null);

        Assert.Equal(value.GetHashCode(), sut.GetHashCode());
    }
}
