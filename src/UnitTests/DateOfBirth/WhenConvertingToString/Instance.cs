using Common;

namespace DateOfBirthTests.WhenConvertingToString;

public class Instance
{
    [Fact]
    public void ShouldReturnValue()
    {
        var value = new DateOnly(1925, 1, 1);
        var sut = DateOfBirth.FromDateOnly(value);

        Assert.Equal(value.ToString(), sut.ToString());
    }
}
