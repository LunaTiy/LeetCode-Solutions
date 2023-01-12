namespace NumberOfNodesInTheSub_TreeWithTheSameLabel;

public class Solution
{
    public int[] CountSubTrees(int n, int[][] edges, string labels)
    {
        Dictionary<int, List<int>> dp = new();

        for (var i = 0; i < n; i++) dp[i] = new List<int>();

        foreach (int[] edge in edges)
        {
            dp[edge[0]].Add(edge[1]);
            dp[edge[1]].Add(edge[0]);
        }

        var result = new int[n];
        Array.Fill(result, 1);

        DFS(dp, labels, 0, -1, result);

        return result;
    }

    private static Dictionary<char, int> DFS(Dictionary<int, List<int>> dp, string labels, int currentNode,
        int prevNode, int[] result)
    {
        if (dp[currentNode].Count == 1 && currentNode != 0)
            return new Dictionary<char, int> { { labels[currentNode], 1 } };

        Dictionary<char, int> countLetterInSubTree = new() { { labels[currentNode], 1 } };

        foreach (int childrenNode in dp[currentNode])
        {
            if (childrenNode == prevNode) continue;
            
            Dictionary<char, int> subTree = DFS(dp, labels, childrenNode, currentNode, result);

            if (subTree.ContainsKey(labels[currentNode]))
                result[currentNode] += subTree[labels[currentNode]];

            countLetterInSubTree = MergeDictionary(countLetterInSubTree, subTree);
        }

        return countLetterInSubTree;
    }

    private static Dictionary<char, int> MergeDictionary(Dictionary<char, int> dict1, Dictionary<char, int> dict2)
    {
        foreach (KeyValuePair<char, int> keyValuePair in dict1)
        {
            if (dict2.ContainsKey(keyValuePair.Key))
                dict2[keyValuePair.Key] += keyValuePair.Value;
            else
                dict2.Add(keyValuePair.Key, keyValuePair.Value);
        }

        return dict2;
    }
}