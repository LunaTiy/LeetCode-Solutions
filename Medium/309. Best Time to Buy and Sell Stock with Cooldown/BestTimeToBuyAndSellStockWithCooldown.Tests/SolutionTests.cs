namespace BestTimeToBuyAndSellStockWithCooldown.Tests;

public class SolutionTests
{
    [Test]
    public void Test1()
    {
        const int result = 3;
        int[] prices = { 1, 2, 3, 0, 2 };

        Assert.AreEqual(result, new Solution().MaxProfit(prices));
    }
}