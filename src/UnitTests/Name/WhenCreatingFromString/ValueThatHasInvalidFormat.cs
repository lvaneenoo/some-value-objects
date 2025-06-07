using Common;

namespace NameTests.WhenCreatingFromString;

public class ValueThatHasInvalidFormat
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
    public void ShouldThrowFormatException(string value)
    {
        Assert.Throws<FormatException>(() => _ = Name.FromString(value));
    }
}
