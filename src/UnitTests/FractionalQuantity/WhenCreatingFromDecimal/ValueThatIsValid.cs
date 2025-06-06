using Common;

namespace FractionalQuantityTests.WhenCreatingFromDecimal;

public class ValueThatIsValid
{
    public static IEnumerable<object[]> CreateArgs()
    {
        yield return new object[]
        {
            0.1M
        };
    }

    [Theory]
    [MemberData(nameof(CreateArgs))]
    public void ShouldReturnInstance(decimal value)
    {
        FractionalQuantity sut = FractionalQuantity.FromDecimal(value);

        Assert.Equal(value.GetHashCode(), sut.GetHashCode());
        Assert.Equal(value.ToString(), sut.ToString());
    }
}
