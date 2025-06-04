using Common;

namespace DateOfBirthTests.WhenGettingHashCode;

[TestClass]
public class OfInstanceThatIsNotUnknown
{
    private readonly DateOnly _value;
    private readonly int _returnValue;

    public OfInstanceThatIsNotUnknown()
    {
        _value = new DateOnly(1925, 1, 1);
        DateOfBirth sut = DateOfBirth.FromDateOnly(_value);

        _returnValue = sut.GetHashCode();
    }

    [TestMethod]
    public void ShouldReturnHashCode() => Assert.AreEqual(_value.GetHashCode(), _returnValue);
}
