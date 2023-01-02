namespace DetectCapital;

public class Solution
{
    public bool DetectCapitalUse(string word)
    {
        var countUpper = 0;
        var firstIsUpper = false;

        if (char.IsUpper(word[0]))
        {
            firstIsUpper = true;
            countUpper++;
        }

        for (var i = 1; i < word.Length; i++)
        {
            char letter = word[i];

            if (char.IsUpper(letter))
            {
                if (!firstIsUpper || countUpper != i)
                    return false;
                
                countUpper++;
            }
            else if (countUpper > 1)
            {
                return false;
            }
        }

        return true;
    }
}