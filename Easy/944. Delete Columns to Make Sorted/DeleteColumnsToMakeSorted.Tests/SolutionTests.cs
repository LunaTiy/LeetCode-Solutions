namespace DeleteColumnsToMakeSorted.Tests;

public class SolutionTests
{
    [Test]
    public void Test1()
    {
        string[] strs = { "abc", "bce", "cae" };
        Assert.AreEqual(1, new Solution().MinDeletionSize(strs));
    }
    
    [Test]
    public void Test2()
    {
        string[] strs = { "a", "b" };
        Assert.AreEqual(0, new Solution().MinDeletionSize(strs));
    }
    
    [Test]
    public void Test3()
    {
        string[] strs = { "zyx", "wvu", "tsr" };
        Assert.AreEqual(3, new Solution().MinDeletionSize(strs));
    }
}