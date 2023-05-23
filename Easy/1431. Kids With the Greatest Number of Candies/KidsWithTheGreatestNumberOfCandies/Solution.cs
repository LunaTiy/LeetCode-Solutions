namespace KidsWithTheGreatestNumberOfCandies;

public class Solution
{
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        int maxBaseCandies = candies.Max();
        var result = new bool[candies.Length];

        for (int i = 0; i < candies.Length; i++)
            if (candies[i] + extraCandies >= maxBaseCandies)
                result[i] = true;

        return result;
    }
}