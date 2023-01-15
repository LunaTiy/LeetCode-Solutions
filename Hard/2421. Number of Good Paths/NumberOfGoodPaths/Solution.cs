namespace NumberOfGoodPaths;

public class Solution
{
    private int[] _root;
    private int[] _count;

    private int Find(int x)
    {
        if (_root[x] == x)
            return x;

        return _root[x] = Find(_root[x]);
    }
    
    public int NumberOfGoodPaths(int[] vals, int[][] edges)
    {
        int length = vals.Length;
        int countGoodPaths = length;
        
        _root = new int[length];
        _count = new int[length];

        for (var i = 0; i < length; i++)
        {
            _root[i] = i;
            _count[i] = 1;
        }

        List<int[]> edgesList = edges.ToList();
        
        edgesList.Sort((x, y) =>
        {
            int value1 = Math.Max(vals[x[0]], vals[x[1]]);
            int value2 = Math.Max(vals[y[0]], vals[y[1]]);
            
            return value1.CompareTo(value2);
        });

        foreach (int[] edge in edgesList)
        {
            int x = edge[0];
            int y = edge[1];

            x = Find(x);
            y = Find(y);

            if (vals[x] == vals[y])
            {
                countGoodPaths += _count[x] * _count[y];
                _root[x] = y;
                _count[y] += _count[x];
            }
            else if (vals[x] > vals[y])
            {
                _root[y] = x;
            }
            else
            {
                _root[x] = y;
            }
        }

        return countGoodPaths;
    }
}