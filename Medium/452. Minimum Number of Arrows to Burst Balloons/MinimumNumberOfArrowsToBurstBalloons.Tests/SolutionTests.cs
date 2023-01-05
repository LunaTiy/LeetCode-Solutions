namespace MinimumNumberOfArrowsToBurstBalloons.Tests;

public class SolutionTests
{
    [Test]
    public void Test1()
    {
        int[][] points = { new[] { 10, 16 }, new[] { 2, 8 }, new[] { 1, 6 }, new[] { 7, 12 } };
        Assert.AreEqual(2, new Solution().FindMinArrowShots(points));
    }
    
    [Test]
    public void Test2()
    {
        int[][] points = { new[] { 1, 2 }, new[] { 3, 4 }, new[] { 5, 6 }, new[] { 7, 8 } };
        Assert.AreEqual(4, new Solution().FindMinArrowShots(points));
    }
    
    [Test]
    public void Test3()
    {
        int[][] points = { new[] { 1, 2 }, new[] { 2, 3 }, new[] { 3, 4 }, new[] { 4, 5 } };
        Assert.AreEqual(2, new Solution().FindMinArrowShots(points));
    }
}