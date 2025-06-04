using Common;

namespace DateOfBirthTests.WhenComparingTo;

[TestClass]
public class InstanceThatIsLess
{
    private readonly int _returnValue;

    public InstanceThatIsLess()
    {
        DateOfBirth sut = DateOfBirth.FromDateOnly(new DateOnly(1925, 1, 1));

        _returnValue = sut.CompareTo(DateOfBirth.Unknown);
    }

    [TestMethod]
    public void ShouldReturnOne() => Assert.AreEqual(1, _returnValue);
}
