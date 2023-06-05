namespace CheckIfItIsStraightLine;

public class Solution
{
    public bool CheckStraightLine(int[][] coordinates)
    {
        if (coordinates.Length == 2)
            return true;

        if (TryGetCoefficients(coordinates, out float k, out float b))
            return coordinates.All(coordinate => Math.Abs(coordinate[1] - (k * coordinate[0] + b)) <= 0.0001);

        int xCoordinate = coordinates[0][0];
        return coordinates.All(coordinate => coordinate[0] == xCoordinate);
    }

    private static bool TryGetCoefficients(int[][] coordinates, out float k, out float b)
    {
        k = 0;
        b = 0;

        float deltaX = coordinates[1][0] - coordinates[0][0];

        if (deltaX == 0)
            return false;

        float deltaY = coordinates[1][1] - coordinates[0][1];

        k = deltaY / deltaX;
        b = deltaY * -coordinates[0][0] / deltaX + coordinates[0][1];

        return true;
    }
}