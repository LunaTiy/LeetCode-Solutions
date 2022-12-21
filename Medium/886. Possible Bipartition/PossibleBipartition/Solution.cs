namespace PossibleBipartition;

public class Solution
{
    public bool PossibleBipartition(int n, int[][] dislikes)
    {
        var colors = new int[n + 1];
        List<List<int>> graph = new();

        for (var i = 0; i < n + 1; i++) graph.Add(new List<int>());

        foreach (int[] dislike in dislikes)
        {
            graph[dislike[0]].Add(dislike[1]);
            graph[dislike[1]].Add(dislike[0]);
        }

        for (var i = 1; i < n + 1; i++)
            if (colors[i] == 0 && !DFS(graph, i, colors, 1))
                return false;

        return true;
    }

    private static bool DFS(IReadOnlyList<List<int>> graph, int index, int[] colors, int color)
    {
        if (colors[index] == color) return true;
        if (colors[index] == -color) return false;
        
        colors[index] = color;
        
        return graph[index].All(next => DFS(graph, next, colors, -color));
    }
}