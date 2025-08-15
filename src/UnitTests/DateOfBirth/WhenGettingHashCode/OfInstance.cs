using Common;

namespace DateOfBirthTests.WhenGettingHashCode;

public class OfInstance
{
    [Fact]
    public void ShouldReturnHashCode()
    {
        var value = new DateOnly(1925, 1, 1);
        var sut = DateOfBirth.FromDateOnly(value);

        Assert.Equal(value.GetHashCode(), sut.GetHashCode());
    }
}
