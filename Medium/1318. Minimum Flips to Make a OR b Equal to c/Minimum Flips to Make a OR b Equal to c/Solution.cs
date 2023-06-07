namespace Minimum_Flips_to_Make_a_OR_b_Equal_to_c;

public class Solution
{
    public int MinFlips(int a, int b, int c)
    {
        if (a + b == c)
            return 0;

        string binaryA = Convert.ToString(a, 2);
        string binaryB = Convert.ToString(b, 2);
        string binaryC = Convert.ToString(c, 2);

        int maxLength = Math.Max(binaryA.Length, Math.Max(binaryB.Length, binaryC.Length));

        if (binaryA.Length < maxLength)
            binaryA = binaryA.PadLeft(maxLength, '0');

        if (binaryB.Length < maxLength)
            binaryB = binaryB.PadLeft(maxLength, '0');

        if (binaryC.Length < maxLength)
            binaryC = binaryC.PadLeft(maxLength, '0');

        int flips = 0;

        for (int i = 0; i < maxLength; i++)
        {
            if (binaryC[i] == '0')
            {
                if (binaryA[i] == '1')
                    flips++;

                if (binaryB[i] == '1')
                    flips++;
            }
            else if (binaryA[i] == '0' && binaryB[i] == '0')
            {
                flips++;
            }
        }

        return flips;
    }
}