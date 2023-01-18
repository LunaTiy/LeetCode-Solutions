namespace MaximumSumCircularSubarray.Tests;

public class SolutionTests
{
    [Test]
    public void Test1()
    {
        int[] nums = { 1, -2, 3, -2 };
        const int result = 3;
        
        Assert.That(new Solution().MaxSubarraySumCircular (nums), Is.EqualTo(result));
    }
    
    [Test]
    public void Test2()
    {
        int[] nums = { 5, -3, 5 };
        const int result = 10;
        
        Assert.That(new Solution().MaxSubarraySumCircular (nums), Is.EqualTo(result));
    }
    
    [Test]
    public void Test3()
    {
        int[] nums = { -3, -2, -3 };
        const int result = -2;
        
        Assert.That(new Solution().MaxSubarraySumCircular (nums), Is.EqualTo(result));
    }
}