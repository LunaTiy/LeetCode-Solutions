namespace FlipStringToMonotoneIncreasing;

public class Solution
{
    public int MinFlipsMonoIncr(string s)
    {
        var onesCount = 0;
        var result = 0;

        foreach (char letter in s)
        {
            if (letter == '1')
            {
                onesCount++;
            }
            else if (onesCount > 0)
            {
                onesCount--;
                result++;
            }
        }

        return result;
    }
}