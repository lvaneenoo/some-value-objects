using Common;

namespace PositiveIntegerTests.WhenGettingHashCode;

public class OfInstance
{
    [Fact]
    public void ShouldReturnHashCode()
    {
        const int value = 1;
        var sut = PositiveInteger.FromInt32(value);

        Assert.Equal(value.GetHashCode(), sut.GetHashCode());
    }
}
