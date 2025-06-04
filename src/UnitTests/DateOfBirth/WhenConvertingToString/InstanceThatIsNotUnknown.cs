using Common;

namespace DateOfBirthTests.WhenConvertingToString;

[TestClass]
public class InstanceThatIsNotUnknown
{
    private readonly DateOnly _value;
    private readonly string _returnValue;

    public InstanceThatIsNotUnknown()
    {
        _value = new DateOnly(1925, 1, 1);
        DateOfBirth sut = DateOfBirth.FromDateOnly(_value);

        _returnValue = sut.ToString();
    }

    [TestMethod]
    public void ShouldReturnValue() => Assert.AreEqual(_value.ToString(), _returnValue);
}
