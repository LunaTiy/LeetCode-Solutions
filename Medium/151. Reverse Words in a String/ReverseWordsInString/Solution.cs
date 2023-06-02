using System.Text;

namespace ReverseWordsInString;

public class Solution
{
    public string ReverseWords(string s)
    {
        string[] words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        StringBuilder builder = new();

        for (int i = words.Length - 1; i >= 0; i--) 
            builder.Append(words[i] + ' ');

        builder.Remove(builder.Length - 1, 1);
        return builder.ToString();
    }
}