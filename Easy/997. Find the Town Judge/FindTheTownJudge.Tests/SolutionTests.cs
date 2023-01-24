namespace FindTheTownJudge.Tests;

public class SolutionTests
{
    [Test]
    public void Test1()
    {
        const int n = 2;
        int[][] trust = { new[] { 1, 2 } };

        const int result = 2;
        
        Assert.AreEqual(result, new Solution().FindJudge(n, trust));
    }
    
    [Test]
    public void Test2()
    {
        const int n = 3;
        int[][] trust = { new[] { 1, 3 }, new[] { 2, 3 } };

        const int result = 3;
        
        Assert.AreEqual(result, new Solution().FindJudge(n, trust));
    }
    
    [Test]
    public void Test3()
    {
        const int n = 3;
        int[][] trust = { new[] { 1, 3 }, new[] { 2, 3 }, new[] { 3, 1 } };

        const int result = -1;
        
        Assert.AreEqual(result, new Solution().FindJudge(n, trust));
    }
    
    [Test]
    public void Test4()
    {
        const int n = 4;
        int[][] trust = { new[] { 1, 3 }, new[] { 1, 4 }, new[] { 2, 3 }, new[] { 2, 4 }, new[] { 4, 3 } };

        const int result = 3;
        
        Assert.AreEqual(result, new Solution().FindJudge(n, trust));
    }
}