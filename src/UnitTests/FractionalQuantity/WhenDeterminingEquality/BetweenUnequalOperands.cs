using Common;

namespace FractionalQuantityTests.WhenDeterminingEquality;

public class BetweenUnequalOperands
{
    public static TheoryData<decimal, decimal> TestData => new()
    {
        { 0M, 0.1M }
    };

    [Theory]
    [MemberData(nameof(TestData))]
    public void ShouldReturnFalse(decimal value1, decimal value2)
    {
        var sut = FractionalQuantity.FromDecimal(value1);

        Assert.False(sut.Equals(FractionalQuantity.FromDecimal(value2)));
    }
}
