namespace HouseRobber;

public class Solution
{
    public int Rob(int[] nums)
    {
        var oddSum = 0;
        var evenSum = 0;
    
        foreach (var number in nums)
        {
            var tempOddSum = oddSum;
            
            oddSum = Math.Max(oddSum, evenSum);
            evenSum = number + tempOddSum;
        }
            
        return Math.Max(oddSum, evenSum);
    }
}