namespace MinimumTimeToCollectAllApplesInTree.Tests;

public class SolutionTests
{
    [Test]
    public void Test1()
    {
        const int n = 7;
        int[][] edges =
            { new[] { 0, 1 }, new[] { 0, 2 }, new[] { 1, 4 }, new[] { 1, 5 }, new[] { 2, 3 }, new[] { 2, 6 } };
        bool[] hasApple = { false, false, true, false, true, true, false };
        
        Assert.That(new Solution().MinTime(n, edges, hasApple), Is.EqualTo(8));
    }
    
    [Test]
    public void Test2()
    {
        const int n = 7;
        int[][] edges =
            { new[] { 0, 1 }, new[] { 0, 2 }, new[] { 1, 4 }, new[] { 1, 5 }, new[] { 2, 3 }, new[] { 2, 6 } };
        bool[] hasApple = { false, false, true, false, false, true, false };
        
        Assert.That(new Solution().MinTime(n, edges, hasApple), Is.EqualTo(6));
    }
    
    [Test]
    public void Test3()
    {
        const int n = 7;
        int[][] edges =
            { new[] { 0, 1 }, new[] { 0, 2 }, new[] { 1, 4 }, new[] { 1, 5 }, new[] { 2, 3 }, new[] { 2, 6 } };
        bool[] hasApple = { false, false, false, false, false, false, false };
        
        Assert.That(new Solution().MinTime(n, edges, hasApple), Is.EqualTo(0));
    }
    
    [Test]
    public void Test4()
    {
        const int n = 4;
        int[][] edges =
            { new[] { 0, 1 }, new[] { 1, 2 }, new[] { 0, 3 } };
        bool[] hasApple = { true, true, true, true };
        
        Assert.That(new Solution().MinTime(n, edges, hasApple), Is.EqualTo(6));
    }
    
    [Test]
    public void Test5()
    {
        const int n = 4;
        int[][] edges =
            { new[] { 0, 1 }, new[] { 1, 2 }, new[] { 0, 3 } };
        bool[] hasApple = { true, true, false, true };
        
        Assert.That(new Solution().MinTime(n, edges, hasApple), Is.EqualTo(4));
    }
}