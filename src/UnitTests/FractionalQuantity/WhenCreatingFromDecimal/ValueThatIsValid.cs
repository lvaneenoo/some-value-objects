using Common;

namespace FractionalQuantityTests.WhenCreatingFromDecimal;

public class ValueThatIsValid
{
    public static TheoryData<decimal> TestData =>
    [
        0M,
        0.1M,
        decimal.MaxValue
    ];

    [Theory]
    [MemberData(nameof(TestData))]
    public void ShouldReturnInstance(decimal value)
    {
        _ = FractionalQuantity.FromDecimal(value);
    }
}
