namespace DetectCapital.Tests;

public class SolutionTests
{
    [Test]
    public void Test1()
    {
        Assert.AreEqual(true, new Solution().DetectCapitalUse("USA"));
    }
    
    [Test]
    public void Test2()
    {
        Assert.AreEqual(false, new Solution().DetectCapitalUse("FlaG"));
    }
    
    [Test]
    public void Test3()
    {
        Assert.AreEqual(false, new Solution().DetectCapitalUse("FFFFFFFFFf"));
    }
}