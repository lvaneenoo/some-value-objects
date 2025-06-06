using Common;

namespace NameTests.WhenParsing;

public class StringThatHasInvalidFormat
{
    public static IEnumerable<object[]> CreateArgs()
    {
        yield return new object[]
        {
            ""
        };

        yield return new object[]
        {
            new string('A', 51)
        };
    }

    [Theory]
    [MemberData(nameof(CreateArgs))]
    public void ShouldThrowFormatException(string s)
    {
        Assert.Throws<FormatException>(() => _ = Name.Parse(s));
    }
}
