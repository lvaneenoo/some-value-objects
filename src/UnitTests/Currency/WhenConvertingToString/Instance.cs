using Common;

namespace CurrencyTests.WhenConvertingToString;

public class Instance
{
    [Fact]
    public void ShouldReturnValue()
    {
        const string value = "EUR";
        var sut = Currency.Parse(value, null);

        Assert.Equal(value, sut.ToString());
    }
}
