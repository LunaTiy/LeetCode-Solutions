namespace MaximumSumCircularSubarray;

public class Solution
{
    public int MaxSubarraySumCircular(int[] nums)
    {
        var totalSum = 0;
        var currentMax = 0;
        var currentMin = 0;
        var maxSum = int.MinValue;
        var minSum = int.MaxValue;

        foreach (int num in nums)
        {
            currentMax = Math.Max(num, currentMax + num);
            maxSum = Math.Max(maxSum, currentMax);
            
            currentMin = Math.Min(num, currentMin + num);
            minSum = Math.Min(minSum, currentMin);
            totalSum += num;
        }
        
        return maxSum > 0 ? Math.Max(maxSum, totalSum - minSum) : maxSum;
    }
}