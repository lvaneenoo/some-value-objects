using Common;

namespace CurrencyTests.WhenConvertingToString;

public class Instance
{
    [Fact]
    public void ShouldReturnValue()
    {
        const string value = "EUR";
        var sut = Currency.Parse(value);

        Assert.Equal(value, sut.ToString());
    }
}
