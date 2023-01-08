namespace MaxPointsOnALine.Tests;

public class SolutionTests
{
    [Test]
    public void Test1()
    {
        int[][] points = { new[] { 1, 1 }, new[] { 2, 2 }, new[] { 3, 3 } };
        const int result = 3;

        Assert.AreEqual(result, new Solution().MaxPoints(points));
    }

    [Test]
    public void Test2()
    {
        int[][] points =
            { new[] { 1, 1 }, new[] { 3, 2 }, new[] { 5, 3 }, new[] { 4, 1 }, new[] { 2, 3 }, new[] { 1, 4 } };
        const int result = 4;

        Assert.AreEqual(result, new Solution().MaxPoints(points));
    }

    [Test]
    public void Test3()
    {
        int[][] points = { new[] { -6, -1 }, new[] { 3, 1 }, new[] { 12, 3 } };
        const int result = 3;

        Assert.AreEqual(result, new Solution().MaxPoints(points));
    }
}