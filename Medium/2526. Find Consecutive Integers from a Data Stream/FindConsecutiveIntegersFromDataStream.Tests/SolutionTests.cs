namespace FindConsecutiveIntegersFromDataStream.Tests;

public class SolutionTests
{
    [Test]
    public void Test1()
    {
        DataStream dataStream = new(4, 3);
        
        Assert.AreEqual(false, dataStream.Consec(4));
        Assert.AreEqual(false, dataStream.Consec(4));
        Assert.AreEqual(true, dataStream.Consec(4));
        Assert.AreEqual(false, dataStream.Consec(3));
    }
}