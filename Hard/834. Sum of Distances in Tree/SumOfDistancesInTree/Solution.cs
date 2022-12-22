namespace SumOfDistancesInTree;

public class Solution
{
    private int[] _nodesCount = null!;
    private int[] _lengthFromTop2Down = null!;
    private int[] _lengthFromDown2Up = null!;
    
    public int[] SumOfDistancesInTree(int n, int[][] edges)
    {
        List<List<int>> graph = InitGraph(n, edges);

        _nodesCount = new int[n].Select(x => x = 1).ToArray();
        _lengthFromTop2Down = new int[n];
        _lengthFromDown2Up = new int[n];

        CountDownLength(graph, -1, 0);
        CountUpLength(graph, -1, 0);

        var result = new int[n];

        for (var i = 0; i < n; i++) result[i] = _lengthFromTop2Down[i] + _lengthFromDown2Up[i];

        return result;
    }

    private static List<List<int>> InitGraph(int n, int[][] edges)
    {
        var graph = new List<List<int>>();
        
        for (var i = 0; i < n; i++)
            graph.Add(new List<int>());

        foreach (int[] edge in edges)
        {
            graph[edge[0]].Add(edge[1]);
            graph[edge[1]].Add(edge[0]);
        }

        return graph;
    }

    private void CountDownLength(IReadOnlyList<List<int>> graph ,int prevNode, int currentNode)
    {
        foreach (int node in graph[currentNode].Where(node => node != prevNode))
        {
            CountDownLength(graph, currentNode, node);
            
            _nodesCount[currentNode] += _nodesCount[node];
            _lengthFromTop2Down[currentNode] += _lengthFromTop2Down[node] + _nodesCount[node];
        }
    }
    
    private void CountUpLength(IReadOnlyList<List<int>> graph ,int prevNode, int currentNode)
    {
        if (prevNode != -1)
            _lengthFromDown2Up[currentNode] = _lengthFromDown2Up[prevNode] + (_lengthFromTop2Down[prevNode] - _lengthFromTop2Down[currentNode] - _nodesCount[currentNode]) +
                                 (graph.Count - _nodesCount[currentNode]);

        foreach (int node in graph[currentNode].Where(node => node != prevNode))
            CountUpLength(graph, currentNode, node);
    }
}