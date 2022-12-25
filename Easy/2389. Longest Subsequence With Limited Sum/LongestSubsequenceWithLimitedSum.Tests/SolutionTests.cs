namespace LongestSubsequenceWithLimitedSum.Tests;

public class SolutionTests
{
    [Test]
    public void Test1()
    {
        int[] result = { 2, 3, 4 };
        int[] nums = { 4, 5, 2, 1 };
        int[] queries = { 3, 10, 21 };

        Assert.AreEqual(result, new Solution().AnswerQueries(nums, queries));
    }
    
    [Test]
    public void Test2()
    {
        int[] result = { 0 };
        int[] nums = { 2, 3, 4, 5 };
        int[] queries = { 1 };

        Assert.AreEqual(result, new Solution().AnswerQueries(nums, queries));
    }
}