namespace FindXor_BeautyOfArray.Tests;

public class SolutionTests
{
    [Test]
    public void Test1()
    {
        int[] values = { 1, 4 };
        const int result = 5;
        
        Assert.AreEqual(result, new Solution().XorBeauty(values));
    }
    
    [Test]
    public void Test2()
    {
        int[] values = { 15, 45, 20, 2, 34, 35, 5, 44, 32, 30 };
        const int result = 34;
        
        Assert.AreEqual(result, new Solution().XorBeauty(values));
    }
}