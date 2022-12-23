namespace BestTimeToBuyAndSellStockWithCooldown;

public class Solution
{
    public int MaxProfit(int[] prices)
    {
        var profit1 = 0; 
        var profit2 = 0;
        
        for (var i = 1; i < prices.Length; i++)
        {
            int tempProfit1 = profit1;
            profit1 = Math.Max(profit1 + prices[i] - prices[i - 1], profit2);
            profit2 = Math.Max(tempProfit1, profit2);
        }

        return Math.Max(profit1, profit2);
    }
}