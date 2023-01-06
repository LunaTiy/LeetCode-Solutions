namespace MaximumIceCreamBars.Tests;

public class SolutionTests
{
    [Test]
    public void Test1()
    {
        int[] costs = { 1, 3, 2, 4, 1 };
        const int coins = 7;
        const int result = 4;
        
        Assert.AreEqual(result, new Solution().MaxIceCream(costs, coins));
    }
    
    [Test]
    public void Test2()
    {
        int[] costs = { 10, 6, 8, 7, 7, 8 };
        const int coins = 5;
        const int result = 0;
        
        Assert.AreEqual(result, new Solution().MaxIceCream(costs, coins));
    }
    
    [Test]
    public void Test3()
    {
        int[] costs = { 1, 6, 3, 1, 2, 5 };
        const int coins = 20;
        const int result = 6;
        
        Assert.AreEqual(result, new Solution().MaxIceCream(costs, coins));
    }
}