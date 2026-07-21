using System.Globalization;

using Common;

namespace DateOfBirthTests.WhenConvertingToString;

public class Instance
{
    public static TheoryData<string?, IFormatProvider?> ValidInput { get; } = new()
    {
        { null, null },
        { null, CultureInfo.CurrentCulture },
        { "d", null },
        { "d", CultureInfo.CurrentCulture }
    };

    [Fact]
    public void ShouldReturnValue()
    {
        var value = new DateOnly(1925, 1, 1);
        var sut = DateOfBirth.FromDateOnly(value);

        Assert.Equal(value.ToString(), sut.ToString());
    }

    [Theory]
    [MemberData(nameof(ValidInput))]
    public void Test(string? format, IFormatProvider? formatProvider)
    {
        var value = new DateOnly(1925, 1, 1);
        var sut = DateOfBirth.FromDateOnly(value);

        Assert.Equal(value.ToString(format, formatProvider), sut.ToString(format, formatProvider));
    }
}
