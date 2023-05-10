namespace SpiralMatrixII;

public class Solution
{
    public int[][] GenerateMatrix(int n)
    {
        int[][] matrix = InitializeMatrix(n);

        FillRow(1, 0, 0, n - 1, n * n, matrix);

        return matrix;
    }

    private static void FillRow(int value, int row, int startIndex, int endIndex, int maxValue, int[][] matrix,
        bool isRightDirection = true)
    {
        if (value == maxValue)
        {
            matrix[row][startIndex] = value;
            return;
        }
        
        if (isRightDirection)
        {
            for (int i = startIndex; i <= endIndex; i++, value++)
                matrix[row][i] = value;

            FillColumn(value, endIndex, startIndex + 1, endIndex, maxValue, matrix);
            return;
        }

        for (int i = startIndex; i >= endIndex; i--, value++)
            matrix[row][i] = value;

        FillColumn(value, endIndex, startIndex, endIndex + 1, maxValue, matrix, isDownDirection: false);
    }

    private static void FillColumn(int value, int column, int startIndex, int endIndex, int maxValue, int[][] matrix,
        bool isDownDirection = true)
    {
        if (value == maxValue)
        {
            matrix[startIndex][column] = value;
            return;
        }
        
        if (isDownDirection)
        {
            for (int i = startIndex; i <= endIndex; i++, value++)
                matrix[i][column] = value;

            FillRow(value, endIndex, endIndex - 1, startIndex - 1, maxValue, matrix, isRightDirection: false);
            return;
        }

        for (int i = startIndex; i >= endIndex; i--, value++)
            matrix[i][column] = value;

        FillRow(value, endIndex, endIndex, startIndex, maxValue, matrix);
    }

    private static int[][] InitializeMatrix(int n)
    {
        var matrix = new int[n][];

        for (int i = 0; i < n; i++)
            matrix[i] = new int[n];

        return matrix;
    }
}