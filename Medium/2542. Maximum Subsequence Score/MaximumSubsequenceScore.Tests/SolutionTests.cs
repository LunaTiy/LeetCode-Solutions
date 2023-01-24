namespace MaximumSubsequenceScore.Tests;

public class SolutionTests
{
    [Test]
    public void Test1()
    {
        int[] nums1 = { 1, 3, 3, 2 };
        int[] nums2 = { 2, 1, 3, 4 };
        const int k = 3;

        const int result = 12;
        
        Assert.AreEqual(result, new Solution().MaxScore(nums1, nums2, k));
    }
    
    [Test]
    public void Test2()
    {
        int[] nums1 = { 4, 2, 3, 1, 1 };
        int[] nums2 = { 7, 5, 10, 9, 6 };
        const int k = 1;

        const int result = 30;
        
        Assert.AreEqual(result, new Solution().MaxScore(nums1, nums2, k));
    }
}