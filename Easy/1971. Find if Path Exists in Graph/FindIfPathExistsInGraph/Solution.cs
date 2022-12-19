namespace FindIfPathExistsInGraph;

public class Solution
{
    public bool ValidPath(int n, int[][] edges, int source, int destination)
    {
        var array = new int[n + 1];

        for (var i = 0; i < n + 1; i++)
            array[i] = i;

        foreach (int[] edge in edges)
        {
            int x = FindElement(edge[0], array);
            int y = FindElement(edge[1], array);

            if (x != y)
                array[x] = y;
        }

        return FindElement(source, array) == FindElement(destination, array);
    }

    private int FindElement(int value, int[] array)
    {
        if (value == array[value])
            return value;

        return array[value] = FindElement(array[value], array);
    }
}