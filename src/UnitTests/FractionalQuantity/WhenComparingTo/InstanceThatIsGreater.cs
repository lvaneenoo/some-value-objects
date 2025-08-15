using Common;

namespace FractionalQuantityTests.WhenComparingTo;

public class InstanceThatIsGreater
{
    public static TheoryData<decimal, decimal> TestData => new()
    {
        { 0M, 0.1M }
    };

    [Theory]
    [MemberData(nameof(TestData))]
    public void ShouldReturnMinusOne(decimal value1, decimal value2)
    {
        var sut = FractionalQuantity.FromDecimal(value1);

        Assert.Equal(-1, sut.CompareTo(FractionalQuantity.FromDecimal(value2)));
    }
}
