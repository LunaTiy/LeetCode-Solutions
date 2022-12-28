namespace RemoveStonesToMinimizeTheTotal.Tests;

public class SolutionTests
{
    [Test]
    public void Test1()
    {
        int[] piles = { 5, 4, 9 };
        const int k = 2;
        
        Assert.AreEqual(12, new Solution().MinStoneSum(piles, k));
    }
    
    [Test]
    public void Test2()
    {
        int[] piles = { 1 };
        const int k = 100000;
        
        Assert.AreEqual(1, new Solution().MinStoneSum(piles, k));
    }
    
    [Test]
    public void Test3()
    {
        int[] piles = { 2695, 9184, 2908, 3869, 3779, 391, 2896, 5328 };
        const int k = 10;
        
        Assert.AreEqual(10946, new Solution().MinStoneSum(piles, k));
    }
}