using Common;

namespace QuantityTests.WhenIncrementing;

[TestClass]
public class InstanceThatIsNotMaxValue
{
    [TestMethod]
    public void ShouldReturnIncrementedInstance() => Assert.AreEqual(Quantity.FromInt32(1), Quantity.Zero.Increment());
}
