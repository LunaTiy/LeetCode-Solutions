namespace NumberOfNodesInTheSub_TreeWithTheSameLabel.Tests;

public class SolutionTests
{
    [Test]
    public void Test1()
    {
        const int n = 7;
        int[][] edges =
            { new[] { 0, 1 }, new[] { 0, 2 }, new[] { 1, 4 }, new[] { 1, 5 }, new[] { 2, 3 }, new[] { 2, 6 } };

        const string labels = "abaedcd";

        int[] result = { 2, 1, 1, 1, 1, 1, 1 };

        Assert.AreEqual(result, new Solution().CountSubTrees(n, edges, labels));
    }

    [Test]
    public void Test2()
    {
        const int n = 4;
        int[][] edges = { new[] { 0, 1 }, new[] { 1, 2 }, new[] { 0, 3 } };

        const string labels = "bbbb";

        int[] result = { 4, 2, 1, 1, };

        Assert.AreEqual(result, new Solution().CountSubTrees(n, edges, labels));
    }
    
    [Test]
    public void Test3()
    {
        const int n = 5;
        int[][] edges = { new[] { 0, 1 }, new[] { 0, 2 }, new[] { 1, 3 }, new[] { 0, 4 } };

        const string labels = "aabab";

        int[] result = { 3, 2, 1, 1, 1 };

        Assert.AreEqual(result, new Solution().CountSubTrees(n, edges, labels));
    }
    
    [Test]
    public void Test4()
    {
        const int n = 7;
        int[][] edges =
            { new[] { 0, 1 }, new[] { 1, 2 }, new[] { 2, 3 }, new[] { 3, 4 }, new[] { 4, 5 }, new[] { 5, 6 } };

        const string labels = "aaabaaa";

        int[] result = { 6, 5, 4, 1, 3, 2, 1 };

        Assert.AreEqual(result, new Solution().CountSubTrees(n, edges, labels));
    }
}