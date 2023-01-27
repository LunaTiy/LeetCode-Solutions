using System.Text;

namespace ConcatenatedWords;

public class Solution
{
    public IList<string> FindAllConcatenatedWordsInADict(string[] words)
    {
        var ans = new HashSet<string>();
        
        if (words.Length < 3)
            return ans.ToList();
        
        var wordSet = new HashSet<string>(words);
        
        foreach(var w in words)
        {
            if (w.Length == 1) continue;
            
            wordSet.Remove(w);
            Build(w, 0, 0, ans, wordSet);
            wordSet.Add(w);
        }
        return ans.ToList();
    }

    private void Build(string word, int pos, int wordCount, HashSet<string> all, HashSet<string> wordSet)
    {
        var length = word.Length;
        
        if(pos >= length && wordCount >=2)
            all.Add(word);
		
        for(var i = 1; i <= Math.Min(length, length-pos); ++i)
        {
            var subStr = word.Substring(pos, i);
            if(wordSet.Contains(subStr))
                Build(word, i+pos, wordCount + 1, all, wordSet);
        }
    }
}