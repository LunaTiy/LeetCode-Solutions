namespace IncreasingTripletSubsequence;

public class Solution
{
    public bool IncreasingTriplet(int[] nums)
    {
        if (nums.Length < 3)
            return false;

        int smallest = int.MaxValue;
        int secondSmallest = int.MaxValue;

        foreach (int num in nums)
        {
            if(num == smallest || num == secondSmallest)
                continue;
            
            if (num <= smallest)
                smallest = num;
            else if (num <= secondSmallest)
                secondSmallest = num;
            else
                return true;
        }
        
        return false;
    }
}