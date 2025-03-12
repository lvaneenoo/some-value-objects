using Common;

namespace PositiveIntegerTests.WhenConvertingToString;

[TestClass]
public class InstanceThatIsNotUnknown
{
    private readonly string _returnValue;
    private readonly int _value;

    public InstanceThatIsNotUnknown()
    {
        _value = 1;
        var sut = PositiveInteger.FromInt32(_value);

        _returnValue = sut.ToString();
    }

    [TestMethod]
    public void ShouldReturnValue()
    {
        Assert.AreEqual(_value.ToString(), _returnValue);
    }
}
