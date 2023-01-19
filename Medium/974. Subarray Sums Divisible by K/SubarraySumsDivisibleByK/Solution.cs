namespace SubarraySumsDivisibleByK;

public class Solution
{
    public int SubarraysDivByK(int[] nums, int k)
    {
        var remainder = 0;
        var result = 0;
        var remainderFrequency = new int[k];
        remainderFrequency[0] = 1;
        
        foreach (int num in nums)
        {
            remainder = (remainder + num % k + k) % k;
            result += remainderFrequency[remainder];
            remainderFrequency[remainder]++;
        }

        return result;
    }
}