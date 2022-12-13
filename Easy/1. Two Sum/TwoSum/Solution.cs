namespace TwoSum;

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> map = new();

        for (var i = 0; i < nums.Length; i++)
        {
            int remainder = target - nums[i];

            if (map.ContainsKey(remainder)) return new[] { map[remainder], i };
            
            map.TryAdd(nums[i], i);
        }

        return null!;
    }
}