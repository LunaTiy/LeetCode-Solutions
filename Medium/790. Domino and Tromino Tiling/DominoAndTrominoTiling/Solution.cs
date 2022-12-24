namespace DominoAndTrominoTiling;

public class Solution
{
    public int NumTilings(int n)
    {
        if (n < 3) return n;

        int module = (int)Math.Pow(10, 9) + 7;
        
        var dp = new long[n + 1];
        dp[0] = 1;
        dp[1] = 1;
        dp[2] = 2;

        for (var i = 3; i < n + 1; i++)
            dp[i] = (2 * dp[i - 1] + dp[i - 3]) % module;

        return (int)dp[n];
    }
}