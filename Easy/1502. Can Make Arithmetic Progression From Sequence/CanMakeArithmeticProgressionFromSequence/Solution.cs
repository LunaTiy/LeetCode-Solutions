namespace CanMakeArithmeticProgressionFromSequence;

public class Solution
{
    public bool CanMakeArithmeticProgression(int[] arr)
    {
        if (arr.Length == 2)
            return true;
        
        Array.Sort(arr);

        int offset = arr[1] - arr[0];
        
        for (int i = 2; i < arr.Length; i++)
            if (arr[i] - arr[i - 1] != offset)
                return false;

        return true;
    }
}