using Common;

namespace FractionalQuantityTests.WhenComparingTo;

public class InstanceThatIsLess
{
    public static TheoryData<decimal, decimal> TestData => new()
    {
        { 0.1M, 0M }
    };

    [Theory]
    [MemberData(nameof(TestData))]
    public void ShouldReturnOne(decimal value1, decimal value2)
    {
        var sut = FractionalQuantity.FromDecimal(value1);

        Assert.Equal(1, sut.CompareTo(FractionalQuantity.FromDecimal(value2)));
    }
}
