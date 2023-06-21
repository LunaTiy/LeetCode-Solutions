namespace StringCompression;

public class Solution
{
    public int Compress(char[] chars)
    {
        int length = chars.Length;

        if (length == 1)
            return 1;

        char prevLetter = chars[0];
        int count = 1;
        int result = 0;

        for (int i = 1; i <= length; i++)
        {
            if (i < length && prevLetter == chars[i])
            {
                count++;
                continue;
            }

            chars[result] = prevLetter;
            result += 1;

            string countStr = count.ToString();
                
            if (count > 1)
            {
                for (int j = 0; j < countStr.Length; j++)
                    chars[result + j] = countStr[j];

                result += countStr.Length;
            }

            if (i < length)
                prevLetter = chars[i];
                
            count = 1;
        }

        return result;
    }
}