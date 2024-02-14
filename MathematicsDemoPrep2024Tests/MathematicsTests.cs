namespace MathematicsDemoPrep2024Tests;
using MathematicsDemoPrep2024;

[TestClass]
public class MathematicsTests
{
    [TestMethod]
    public void Mathematics_Prime_3_ShouldBeTrue()
    {
        Mathematics m = new Mathematics();
        Assert.AreEqual(true, m.Prime(3));
    }

    [TestMethod]
    public void Mathematics_Prime_4_ShouldBeFalse()
    {
        Mathematics m = new Mathematics();
        Assert.AreEqual(false, m.Prime(4));
    }

    [TestMethod]
    public void Mathematics_Prime_9_ShouldBeFalse()
    {
        Mathematics m = new Mathematics();
        Assert.AreEqual(false, m.Prime(9));
    }

}
