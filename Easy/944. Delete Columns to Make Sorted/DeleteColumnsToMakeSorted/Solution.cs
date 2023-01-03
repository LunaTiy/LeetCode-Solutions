namespace DeleteColumnsToMakeSorted;

public class Solution
{
    public int MinDeletionSize(string[] strs)
    {
        var columnNumbers = 0;

        for (var i = 0; i < strs[0].Length; i++)
        {
            int maxAsciiCode = char.MinValue;
            
            for (var j = 0; j < strs.Length; j++)
            {
                if (strs[j][i] < maxAsciiCode)
                {
                    columnNumbers++;
                    break;
                }

                maxAsciiCode = strs[j][i];
            }    
        }
        
        return columnNumbers;
    }
}