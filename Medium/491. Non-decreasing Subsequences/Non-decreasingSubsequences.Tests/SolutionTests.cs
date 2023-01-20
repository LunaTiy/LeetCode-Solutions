namespace Non_decreasingSubsequences.Tests;

public class SolutionTests
{
    [Test]
    public void Test1()
    {
        int[] nums = { 4, 6, 7, 7 };
        List<List<int>> result = new()
        {
            new List<int> { 4, 6 }, new List<int> { 4, 6, 7 }, new List<int> { 4, 6, 7, 7 }, new List<int> { 4, 7 },
            new List<int> { 4, 7, 7 }, new List<int> { 6, 7 }, new List<int> { 6, 7, 7 }, new List<int> { 7, 7 }
        };
        
        Assert.AreEqual(result, new Solution().FindSubsequences(nums));
    }
}