using Common;

namespace FractionalQuantityTests.WhenCreatingFromDecimal;

public class ValueThatIsOutOfRange
{
    public static IEnumerable<object[]> CreateArgs()
    {
        yield return new object[]
        {
            -0.1M
        };
    }

    [Theory]
    [MemberData(nameof(CreateArgs))]
    public void ShouldThrowArgumentOutOfRangeException(decimal value)
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => _ = FractionalQuantity.FromDecimal(value));
    }
}
