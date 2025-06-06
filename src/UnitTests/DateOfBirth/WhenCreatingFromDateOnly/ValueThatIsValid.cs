using Common;

namespace DateOfBirthTests.WhenCreatingFromDateOnly;

public class ValueThatIsValid
{
    public static IEnumerable<object[]> CreateArgs()
    {
        yield return new object[]
        {
            MinValue
        };
    }

    private static readonly DateOnly MinValue = new(1925, 1, 1);

    [Theory]
    [MemberData(nameof(CreateArgs))]
    public void ShouldReturnInstance(DateOnly value)
    {
        DateOfBirth sut = DateOfBirth.FromDateOnly(value);

        Assert.Equal(value.GetHashCode(), sut.GetHashCode());
        Assert.Equal(value.ToString(), sut.ToString());
    }
}
