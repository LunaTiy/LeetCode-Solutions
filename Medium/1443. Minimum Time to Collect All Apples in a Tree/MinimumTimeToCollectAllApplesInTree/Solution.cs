namespace MinimumTimeToCollectAllApplesInTree;

public class Solution
{
    public int MinTime(int n, int[][] edges, IList<bool> hasApple)
    {
        if (n == 1)
            return 0;

        Dictionary<int, List<int>> dp = new();

        for (var i = 0; i < n; i++) dp[i] = new List<int>();

        foreach (int[] edge in edges)
        {
            dp[edge[0]].Add(edge[1]);
            dp[edge[1]].Add(edge[0]);
        }

        int time = DFS(dp, hasApple, 0, -1);
        return hasApple[0] || time != 0 ? time - 2 : time;
    }

    private static int DFS(Dictionary<int, List<int>> dp, IList<bool> hasApple, int currentNode, int prevNode)
    {
        if (dp[currentNode].Count == 0)
            return hasApple[currentNode] ? 2 : 0;

        var steps = 0;
        
        foreach (int childrenNode in dp[currentNode])
        {
            if(childrenNode == prevNode) continue;
            steps += DFS(dp, hasApple, childrenNode, currentNode);
        }

        return hasApple[currentNode] || steps != 0 ? steps + 2 : steps;
    }
}