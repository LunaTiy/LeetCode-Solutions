namespace InsertInterval.Tests;

public class SolutionTests
{
    [Test]
    public void Test1()
    {
        int[][] intervals = { new[] { 1, 3 }, new[] { 6, 9 } };
        int[] newInterval = { 2, 5 };

        int[][] result = { new[] { 1, 5 }, new[] { 6, 9 } };
        Assert.That(new Solution().Insert(intervals, newInterval), Is.EqualTo(result));
    }
    
    [Test]
    public void Test2()
    {
        int[][] intervals = { new[] { 1, 2 }, new[] { 3, 5 }, new[] { 6, 7 }, new[] { 8, 10 }, new[] { 12, 16 } };
        int[] newInterval = { 4, 8 };

        int[][] result = { new[] { 1, 2 }, new[] { 3, 10 }, new[] { 12, 16 } };
        Assert.That(new Solution().Insert(intervals, newInterval), Is.EqualTo(result));
    }
}