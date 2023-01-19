namespace SubarraySumsDivisibleByK.Tests;

public class SolutionTests
{
    [Test]
    public void Test1()
    {
        int[] nums = { 4, 5, 0, -2, -3, 1 };
        const int k = 5;
        const int result = 7;
        
        Assert.AreEqual(result, new Solution().SubarraysDivByK(nums, k));
    }
    
    [Test]
    public void Test2()
    {
        int[] nums = { 5 };
        const int k = 9;
        const int result = 0;
        
        Assert.AreEqual(result, new Solution().SubarraysDivByK(nums, k));
    }
}