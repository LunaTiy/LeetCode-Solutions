using System.Text;

namespace ReverseVowelsOfString;

public class Solution
{
    private const string VowelLetters = "aeiouAEIOU";
    
    public string ReverseVowels(string s)
    {
        StringBuilder builder = new(s);

        int i = 0;
        int j = s.Length - 1;
            
        while (i < j)
        {
            while (i < s.Length && !IsVowel(builder[i]))
                i++;

            while (j >= 0 && !IsVowel(builder[j]))
                j--;

            if (i >= j)
                break;
            
            (builder[i], builder[j]) = (builder[j], builder[i]);
            i++;
            j--;
        }
        
        return builder.ToString();
    }

    private static bool IsVowel(char letter) =>
        VowelLetters.Contains(letter);
}