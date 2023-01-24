namespace FindTheTownJudge;

public class Solution
{
    public int FindJudge(int n, int[][] trust)
    {
        var countTrusts = new int[n + 1];

        foreach (int[] ints in trust)
        {
            countTrusts[ints[0]]--;
            countTrusts[ints[1]]++;
        }

        for (var i = 1; i < countTrusts.Length; i++)
            if (countTrusts[i] == n - 1)
                return i;

        return -1;
    }
}