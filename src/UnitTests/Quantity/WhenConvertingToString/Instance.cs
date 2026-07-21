using System.Globalization;

using Common;

namespace QuantityTests.WhenConvertingToString;

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
        const int value = 1;
        var sut = Quantity.FromInt32(value);

        Assert.Equal(value.ToString(), sut.ToString());
    }

    [Theory]
    [MemberData(nameof(ValidInput))]
    public void Test(string? format, IFormatProvider? formatProvider)
    {
        const int value = 1;
        var sut = Quantity.FromInt32(value);

        Assert.Equal(value.ToString(format, formatProvider), sut.ToString(format, formatProvider));
    }
}
