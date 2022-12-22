namespace SumOfDistancesInTree.Tests;

public class SolutionTests
{
    [Test]
    public void Test1()
    {
        const int nodeCount = 6;
        int[][] edges = { new[] { 0, 1 }, new[] { 0, 2 }, new[] { 2, 3 }, new[] { 2, 4 }, new[] { 2, 5 } };

        int[] result = { 8, 12, 6, 10, 10, 10 };

        Assert.AreEqual(result, new Solution().SumOfDistancesInTree(nodeCount, edges));
    }
    
    [Test]
    public void Test2()
    {
        const int nodeCount = 1;
        int[][] edges = { };

        int[] result = { 0 };

        Assert.AreEqual(result, new Solution().SumOfDistancesInTree(nodeCount, edges));
    }
    
    [Test]
    public void Test3()
    {
        const int nodeCount = 2;
        int[][] edges = { new[] { 1, 0 } };

        int[] result = { 1, 1 };

        Assert.AreEqual(result, new Solution().SumOfDistancesInTree(nodeCount, edges));
    }
}