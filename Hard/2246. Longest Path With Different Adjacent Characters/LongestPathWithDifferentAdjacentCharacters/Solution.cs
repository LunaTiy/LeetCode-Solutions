namespace LongestPathWithDifferentAdjacentCharacters;

public class Solution
{
    private int _longestPathValue = 1;
    
    public int LongestPath(int[] parent, string s)
    {
        Dictionary<int, List<int>> dp = new();

        for (var i = 0; i < parent.Length; i++) dp[i] = new List<int>();

        for (var i = 1; i < parent.Length; i++)
        {
            int parentNode = parent[i];
            dp[parentNode].Add(i);
        }

        DFS(dp, s, 0);
        return _longestPathValue;
    }

    private int DFS(Dictionary<int, List<int>> dp, string s, int node)
    {
        var max = 0;
        var secondMax = 0;

        foreach (int childrenNode in dp[node])
        {
            int path = DFS(dp, s, childrenNode);
            
            if(s[node] == s[childrenNode])
                continue;

            if (path > max)
            {
                secondMax = max;
                max = path;
            }
            else if (path > secondMax)
            {
                secondMax = path;
            }
        }

        _longestPathValue = Math.Max(_longestPathValue, max + secondMax + 1);
        return max + 1;
    }
}