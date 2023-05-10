namespace SpiralMatrixII.Tests;

public class SolutionTests
{
    private readonly Solution _solution = new();

    [Test]
    public void Test1()
    {
        const int n = 3;
        int[][] result = { new[] { 1, 2, 3 }, new[] { 8, 9, 4 }, new[] { 7, 6, 5 } };

        Assert.That(_solution.GenerateMatrix(n), Is.EqualTo(result));
    }

    [Test]
    public void Test2()
    {
        const int n = 4;
        int[][] result =
            { new[] { 1, 2, 3, 4 }, new[] { 12, 13, 14, 5 }, new[] { 11, 16, 15, 6 }, new[] { 10, 9, 8, 7 } };

        Assert.That(_solution.GenerateMatrix(n), Is.EqualTo(result));
    }

    [Test]
    public void Test3()
    {
        const int n = 1;
        int[][] result = { new[] { 1 } };

        Assert.That(_solution.GenerateMatrix(n), Is.EqualTo(result));
    }
}