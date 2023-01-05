namespace MinimumNumberOfArrowsToBurstBalloons;

public class Solution
{
    public int FindMinArrowShots(int[][] points)
    {
        Array.Sort(points, (x, y) => x[0].CompareTo(y[0]));
        int lastPoint = points[0][1];
        var result = 1;

        foreach (int[] point in points)
        {
            if (point[0] > lastPoint)
            {
                result++;
                lastPoint = point[1];
            }

            lastPoint = Math.Min(point[1], lastPoint);
        }
        
        return result;
    }
}