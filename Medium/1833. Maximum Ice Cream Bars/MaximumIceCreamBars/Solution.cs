namespace MaximumIceCreamBars;

public class Solution
{
    public int MaxIceCream(int[] costs, int coins)
    {
        Array.Sort(costs);
        var countIceCreamBars = 0;

        foreach (int cost in costs)
        {
            if (coins <= 0)
                break;

            coins -= cost;

            if (coins < 0)
                break;
            
            countIceCreamBars++;
        }
        
        return countIceCreamBars;
    }
}