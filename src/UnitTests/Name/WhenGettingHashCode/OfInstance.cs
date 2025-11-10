using Common;

namespace NameTests.WhenGettingHashCode;

public class OfInstance
{
    [Fact]
    public void ShouldReturnHashCode()
    {
        const string value = "A";
        var sut = Name.Parse(value, null);

        Assert.Equal(value.GetHashCode(), sut.GetHashCode());
    }
}
