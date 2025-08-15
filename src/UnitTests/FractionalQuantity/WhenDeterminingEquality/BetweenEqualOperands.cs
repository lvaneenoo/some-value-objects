using Common;

namespace FractionalQuantityTests.WhenDeterminingEquality;

public class BetweenEqualOperands
{
    public static TheoryData<decimal, decimal> TestData => new()
    {
        { 0M, 0M }
    };

    [Theory]
    [MemberData(nameof(TestData))]
    public void ShouldReturnTrue(decimal value1, decimal value2)
    {
        var sut = FractionalQuantity.FromDecimal(value1);

        Assert.True(sut.Equals(FractionalQuantity.FromDecimal(value2)));
    }
}
