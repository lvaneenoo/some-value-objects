using Common;

namespace PositiveIntegerTests.WhenConvertingToString;

public class Instance
{
    [Fact]
    public void ShouldReturnValue()
    {
        const int value = 1;
        var sut = PositiveInteger.FromInt32(value);

        Assert.Equal(value.ToString(), sut.ToString());
    }
}
