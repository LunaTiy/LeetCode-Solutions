namespace NumberOfGoodPaths.Tests;

public class SolutionTests
{
    [Test]
    public void Test1()
    {
        int[] vals = { 1, 3, 2, 1, 3 };
        int[][] edges = { new[] { 0, 1 }, new[] { 0, 2 }, new[] { 2, 3 }, new[] { 2, 4 } };
        const int result = 6;
        
        Assert.AreEqual(result, new Solution().NumberOfGoodPaths(vals, edges));
    }
    
    [Test]
    public void Test2()
    {
        int[] vals = { 1, 1, 2, 2, 3 };
        int[][] edges = { new[] { 0, 1 }, new[] { 1, 2 }, new[] { 2, 3 }, new[] { 2, 4 } };
        const int result = 7;
        
        Assert.AreEqual(result, new Solution().NumberOfGoodPaths(vals, edges));
    }
    
    [Test]
    public void Test3()
    {
        int[] vals = { 1 };
        int[][] edges = { };
        const int result = 1;
        
        Assert.AreEqual(result, new Solution().NumberOfGoodPaths(vals, edges));
    }
}