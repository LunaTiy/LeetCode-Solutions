namespace DominoAndTrominoTiling.Tests;

public class SolutionTests
{
    [Test]
    public void Test1()
    {
        Assert.AreEqual(5, new Solution().NumTilings(3));
    }
    
    [Test]
    public void Test2()
    {
        Assert.AreEqual(11, new Solution().NumTilings(4));
    }
    [Test]
    public void Test3()
    {
        Assert.AreEqual(312342182, new Solution().NumTilings(30));
    }
    
    
    [Test]
    public void Test4()
    {
        Assert.AreEqual(1, new Solution().NumTilings(1));
    }
}