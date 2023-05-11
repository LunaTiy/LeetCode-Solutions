namespace UncrossedLines;

public class Solution
{
    public int MaxUncrossedLines(int[] nums1, int[] nums2)
    {
        if (nums1.Length < nums2.Length) 
            (nums1, nums2) = (nums2, nums1);

        var dp = new int[nums2.Length + 1];

        for (int i = 1; i <= nums1.Length; i++)
        {
            int previous = 0;

            for (int j = 1; j <= nums2.Length; j++)
            {
                int current = dp[j];

                if (nums1[i - 1] == nums2[j - 1])
                    dp[j] = previous + 1;
                else
                    dp[j] = Math.Max(dp[j - 1], current);

                previous = current;
            }
        }

        return dp[nums2.Length];
    }
}