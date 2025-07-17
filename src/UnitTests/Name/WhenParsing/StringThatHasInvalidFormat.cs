using Common;

namespace NameTests.WhenParsing;

public class StringThatHasInvalidFormat
{
    public static TheoryData<string> CreateArgs()
        =>
        [
            "",
            new string(' ', 51)
        ];

    [Theory]
    [MemberData(nameof(CreateArgs))]
    public void ShouldThrowFormatException(string s) => Assert.Throws<FormatException>(() => Name.Parse(s));
}
