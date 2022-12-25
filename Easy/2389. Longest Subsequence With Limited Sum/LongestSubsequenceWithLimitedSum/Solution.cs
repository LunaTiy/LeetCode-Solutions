namespace LongestSubsequenceWithLimitedSum;

public class Solution
{
    public int[] AnswerQueries(int[] nums, int[] queries)
    {
        var result = new int[queries.Length];
        Array.Sort(nums);

        for (var i = 0; i < queries.Length; i++)
        {
            var sum = 0;

            foreach (int number in nums)
            {
                if(sum + number > queries[i]) break;

                sum += number;
                result[i]++;
            }
        }

        return result;
    }
}