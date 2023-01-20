namespace Non_decreasingSubsequences;

public class Solution
{
    public IList<IList<int>> FindSubsequences(int[] nums)
    {
        var result = new List<IList<int>>();

        DFS(result, nums, 0, new List<int>());

        return new List<IList<int>>(result);
    }

    private static void DFS(ICollection<IList<int>> result, int[] nums, int currentIndex, List<int> currentSubsequence)
    {
        if (currentSubsequence.Count > 1)
            result.Add(new List<int>(currentSubsequence));

        HashSet<int> visited = new();

        for (int i = currentIndex; i < nums.Length; i++)
        {
            if(visited.Contains(nums[i])) continue;

            if (currentSubsequence.Count == 0 || nums[i] >= currentSubsequence[^1])
            {
                currentSubsequence.Add(nums[i]);
                visited.Add(nums[i]);
                
                DFS(result, nums, i + 1, currentSubsequence);
                currentSubsequence.RemoveAt(currentSubsequence.Count - 1);
            }
        }
    }
}