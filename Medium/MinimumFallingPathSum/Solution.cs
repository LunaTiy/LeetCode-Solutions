namespace MinimumFallingPathSum;

public class Solution
{
    public int MinFallingPathSum(int[][] matrix)
    {
        int matrixLength = matrix.Length;
        var newMatrix = new int[matrixLength][];

        newMatrix[0] = new int[matrixLength];
        
        for (var j = 0; j < matrixLength; j++) newMatrix[0][j] = matrix[0][j];

        for (var i = 1; i < matrixLength; i++)
        {
            newMatrix[i] = new int[matrixLength];
            
            for (var j = 0; j < matrixLength; j++)
            {
                int minValue = newMatrix[i - 1][j];

                if (j - 1 >= 0) minValue = Math.Min(minValue, newMatrix[i - 1][j - 1]);
                if (j + 1 < matrixLength) minValue = Math.Min(minValue, newMatrix[i - 1][j + 1]);

                newMatrix[i][j] = minValue + matrix[i][j];
            }
        }

        return newMatrix[^1].Min();
    }
}