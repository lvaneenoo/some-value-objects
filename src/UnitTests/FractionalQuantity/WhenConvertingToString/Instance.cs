using System.Globalization;

using Common;

namespace FractionalQuantityTests.WhenConvertingToString;

public class Instance
{
    public static TheoryData<string?, IFormatProvider?> ValidInput { get; } = new()
    {
        { null, null },
        { null, CultureInfo.CurrentCulture },
        { "G", null },
        { "G", CultureInfo.CurrentCulture }
    };

    [Fact]
    public void ShouldReturnValue()
    {
        const decimal value = 0.1M;
        var sut = FractionalQuantity.FromDecimal(value);

        Assert.Equal(value.ToString(), sut.ToString());
    }

    [Theory]
    [MemberData(nameof(ValidInput))]
    public void Test(string? format, IFormatProvider? formatProvider)
    {
        const decimal value = 0.1M;
        var sut = FractionalQuantity.FromDecimal(value);

        Assert.Equal(value.ToString(format, formatProvider), sut.ToString(format, formatProvider));
    }
}
