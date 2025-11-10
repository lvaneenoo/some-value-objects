using Common;

namespace NameTests.WhenConvertingToString;

public class Instance
{
    [Fact]
    public void ShouldReturnValue()
    {
        const string value = "A";
        var sut = Name.Parse(value, null);

        Assert.Equal(value, sut.ToString());
    }
}
