using System.Text;

namespace LexicographicallySmallestEquivalentString;

public class Solution
{
    private int[] _p;
    
    public string SmallestEquivalentString(string s1, string s2, string baseStr)
    {
        int length = s1.Length;
        _p = new int[26];

        for (var i = 0; i < _p.Length; i++) _p[i] = i;

        for (var i = 0; i < length; i++)
        {
            int letter1 = s1[i] - 'a';
            int letter2 = s2[i] - 'a';

            int findLetter1 = Find(letter1);
            int findLetter2 = Find(letter2);

            if (findLetter1 < findLetter2)
                _p[findLetter2] = findLetter1;
            else
                _p[findLetter1] = findLetter2;
        }

        StringBuilder builder = new();

        foreach (char letter in baseStr)
        {
            var targetLetter = (char)(Find(letter - 'a') + 'a');
            builder.Append(targetLetter);
        }
        
        return builder.ToString();
    }

    private int Find(int x)
    {
        if (_p[x] != x)
            _p[x] = Find(_p[x]);

        return _p[x];
    }
}