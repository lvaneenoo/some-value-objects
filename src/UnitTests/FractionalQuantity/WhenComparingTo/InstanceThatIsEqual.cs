using Common;

namespace FractionalQuantityTests.WhenComparingTo;

public class InstanceThatIsEqual
{
    public static TheoryData<decimal, decimal> TestData => new()
    {
        { 0M, 0M }
    };

    [Theory]
    [MemberData(nameof(TestData))]
    public void ShouldReturnZero(decimal value1, decimal value2)
    {
        var sut = FractionalQuantity.FromDecimal(value1);

        Assert.Equal(0, sut.CompareTo(FractionalQuantity.FromDecimal(value2)));
    }
}
