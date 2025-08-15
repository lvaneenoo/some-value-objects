using Common;

namespace NameTests.WhenParsing;

public class StringThatHasInvalidFormat
{
    private const int MaxLength = 50;

    public static TheoryData<string> TestData =>
    [
        "",
        new string(' ', MaxLength + 1)
    ];

    [Theory]
    [MemberData(nameof(TestData))]
    public void ShouldThrowFormatException(string s)
    {
        Assert.Throws<FormatException>(() => _ = Name.Parse(s));
    }
}
