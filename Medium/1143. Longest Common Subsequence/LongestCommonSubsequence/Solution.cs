namespace LongestCommonSubsequence;

public class Solution
{
    public int LongestCommonSubsequence(string text1, string text2)
    {
        var matrix = new int[text1.Length + 1, text2.Length + 1];

        for (var i = 0; i < text1.Length; i++)
            for (var j = 0; j < text2.Length; j++)
                matrix[i + 1, j + 1] =
                    text1[i] == text2[j] ? matrix[i, j] + 1 : Math.Max(matrix[i + 1, j], matrix[i, j + 1]);

        return matrix[text1.Length, text2.Length];
    }
}