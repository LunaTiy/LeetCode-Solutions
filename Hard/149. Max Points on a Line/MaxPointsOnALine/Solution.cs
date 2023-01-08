namespace MaxPointsOnALine;

public class Solution
{
    public int MaxPoints(int[][] points)
    {
        if (points.Length <= 2)
            return points.Length;

        var result = 0;

        foreach (int[] point1 in points)
        {
            Dictionary<double, int> map = new();
            double x1 = point1[0];
            double y1 = point1[1];

            foreach (int[] point2 in points)
            {
                if(point1 == point2) continue;

                double x2 = point2[0];
                double y2 = point2[1];

                double k = x2 - x1 == 0 ? int.MaxValue : (y2 - y1) / (x2 - x1);

                if(map.ContainsKey(k))
                    map[k]++;
                else
                    map.Add(k, 2);
                
                result = Math.Max(result, map[k]);
            }
        }

        return result;
    }
}