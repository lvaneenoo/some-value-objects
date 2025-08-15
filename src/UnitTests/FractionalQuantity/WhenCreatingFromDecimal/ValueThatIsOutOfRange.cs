using Common;

namespace FractionalQuantityTests.WhenCreatingFromDecimal;

public class ValueThatIsOutOfRange
{
    public static TheoryData<decimal> TestData =>
    [
        -0.1M
    ];

    [Theory]
    [MemberData(nameof(TestData))]
    public void ShouldThrowArgumentOutOfRangeException(decimal value)
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => _ = FractionalQuantity.FromDecimal(value));
    }
}
