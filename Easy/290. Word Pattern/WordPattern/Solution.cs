namespace WordPattern;

public class Solution
{
    public bool WordPattern(string pattern, string s)
    {
        string[] words = s.Split(' ');

        if (words.Length != pattern.Length)
            return false;
        
        var letterToWord = new Dictionary<char, string>();

        for (var i = 0; i < pattern.Length && i < words.Length; i++)
        {
            char letter = pattern[i];
            string word = words[i];
            
            if (!letterToWord.ContainsKey(letter))
            {
                if (letterToWord.ContainsValue(word))
                    return false;
                
                letterToWord.Add(letter, word);
                continue;
            }

            if (letterToWord[letter] != word)
                return false;
        }

        return true;
    }
}