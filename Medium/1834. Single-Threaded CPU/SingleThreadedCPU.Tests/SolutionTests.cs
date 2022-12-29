namespace SingleThreadedCPU.Tests;

public class SolutionTests
{
    [Test]
    public void Test1()
    {
        int[][] tasks =
        {
            new[] { 1, 2 },
            new[] { 2, 4 },
            new[] { 3, 2 },
            new[] { 4, 1 },
        };

        int[] result = { 0, 2, 3, 1 };

        Assert.AreEqual(result, new Solution().GetOrder(tasks));
    }
    
    [Test]
    public void Test2()
    {
        int[][] tasks =
        {
            new[] { 7, 10 },
            new[] { 7, 12 },
            new[] { 7, 5 },
            new[] { 7, 4 },
            new[] { 7, 2 },
        };

        int[] result = { 4, 3, 2, 0, 1 };

        Assert.AreEqual(result, new Solution().GetOrder(tasks));
    }
}