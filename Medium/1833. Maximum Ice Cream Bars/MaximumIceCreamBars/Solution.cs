namespace MaximumIceCreamBars;

public class Solution
{
    public int MaxIceCream(int[] costs, int coins)
    {
        Array.Sort(costs);
        
        if (coins < costs[0])
            return 0;

        var sumCosts = new int[costs.Length];
        sumCosts[0] = costs[0];

        for (var i = 1; i < costs.Length; i++)
        {
            sumCosts[i] = sumCosts[i - 1] + costs[i];

            if (coins < sumCosts[i])
                return i;
        }

        return costs.Length;
    }
}