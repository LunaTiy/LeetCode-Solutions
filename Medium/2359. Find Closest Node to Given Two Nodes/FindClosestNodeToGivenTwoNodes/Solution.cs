namespace FindClosestNodeToGivenTwoNodes;

public class Solution
{
    public int ClosestMeetingNode(int[] edges, int node1, int node2)
    {
        int length = edges.Length;
        
        var dist1 = new int[length];
        var dist2 = new int[length];
        
        Array.Fill(dist1, int.MaxValue);
        Array.Fill(dist2, int.MaxValue);

        dist1[node1] = 0;
        dist2[node2] = 0;

        var isVisit1 = new bool[length];
        var isVisit2 = new bool[length];
        
        DFS(edges, node1, isVisit1, dist1);
        DFS(edges, node2, isVisit2, dist2);

        int minDist = -1;
        var minDistTillNow = int.MaxValue;
        
        for (var currentNode = 0; currentNode < length; currentNode++)
        {
            if (minDistTillNow > Math.Max(dist1[currentNode], dist2[currentNode]))
            {
                minDist = currentNode;
                minDistTillNow = Math.Max(dist1[currentNode], dist2[currentNode]);
            }
        }

        return minDist;
    }

    private static void DFS(int[] edges, int currentNode, bool[] isVisit, int[] dist)
    {
        if (isVisit[currentNode])
            return;
        
        isVisit[currentNode] = true;
        int neighbor = edges[currentNode];

        if (neighbor != -1 && !isVisit[neighbor])
        {
            dist[neighbor] = dist[currentNode] + 1;
            DFS(edges, neighbor, isVisit, dist);
        }
    }
}