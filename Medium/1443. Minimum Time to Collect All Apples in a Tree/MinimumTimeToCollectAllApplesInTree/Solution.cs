namespace MinimumTimeToCollectAllApplesInTree;

public class Solution
{
    public int MinTime(int n, int[][] edges, IList<bool> hasApple)
    {
        if (n == 1)
            return 0;

        Dictionary<int, List<int>> dp = new();

        for (var i = 0; i < n; i++) dp[i] = new List<int>();

        foreach (int[] edge in edges) dp[edge[0]].Add(edge[1]);

        int sub = hasApple[0] ? 2 : 0;
        return DFS(dp, hasApple, 0) - sub;
    }

    private static int DFS(Dictionary<int, List<int>> dp, IList<bool> hasApple, int currentNode)
    {
        if (dp[currentNode].Count == 0)
            return hasApple[currentNode] ? 2 : 0;

        int steps = 0;
        
        foreach (int childrenNode in dp[currentNode])
            steps += DFS(dp, hasApple, childrenNode);

        return steps != 0 ? steps + 2 : 0;
    }
}