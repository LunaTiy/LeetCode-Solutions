namespace MaximumSubsequenceScore;

public class Solution
{
    public long MaxScore(int[] nums1, int[] nums2, int k)
    {
        var nums = new long[nums1.Length][];
        
        for (var i = 0; i < nums.Length; i++)
            nums[i] = new long[] { nums1[i], nums2[i] };
        
        nums = nums.OrderBy(x => x[1]).ToArray();
        
        var priorityQueue = new PriorityQueue<long, long>();
        long res = 0;
        long sum = 0;
        
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            sum += nums[i][0];
            priorityQueue.Enqueue(nums[i][0], nums[i][0]);
            
            if (priorityQueue.Count > k)
                sum -= priorityQueue.Dequeue();
            
            nums[i][0] = sum;
        }
        
        for (var i = 0; i <= nums.Length - k; i++)
            res = Math.Max(res, nums[i][0] * nums[i][1]);
        
        return res;
    }
}