using System.Text;

namespace MergeStringsAlternately;

public class Solution
{
    public string MergeAlternately(string word1, string word2)
    {
        int i = 0;
        int j = 0;

        int length1 = word1.Length;
        int length2 = word2.Length;

        StringBuilder builder = new();
        
        while (i < length1 || j < length2)
        {
            if (i < word1.Length)
                builder.Append(word1[i++]);
            if (j < word2.Length)
                builder.Append(word2[j++]);
        }

        return builder.ToString();
    }
}