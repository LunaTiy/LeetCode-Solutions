namespace InsertInterval;

public class Solution
{
    public int[][] Insert(int[][] intervals, int[] newInterval)
    {
        var result = new Queue<int[]>();
        
        foreach (int[] interval in intervals)
        {
            if (interval[1] < newInterval[0])
            {
                result.Enqueue(interval);
            }
            else if (interval[0] > newInterval[1])
            {
                result.Enqueue(newInterval);
                newInterval = interval;
            }
            else
            {
                newInterval[0] = Math.Min(newInterval[0], interval[0]);
                newInterval[1] = Math.Max(newInterval[1], interval[1]);
            }
        }
        
        result.Enqueue(newInterval);
        return result.ToArray();
    }
}