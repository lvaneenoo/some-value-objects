using Common;

namespace PositiveIntegerTests.WhenCreatingFromInt32;

public class ValueThatIsValid
{
    [Theory]
    [InlineData(1)]
    public void ShouldReturnInstance(int value)
    {
        PositiveInteger sut = PositiveInteger.FromInt32(value);

        Assert.Equal(value.GetHashCode(), sut.GetHashCode());
        Assert.Equal(value.ToString(), sut.ToString());
    }
}
