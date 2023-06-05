namespace CheckIfItIsStraightLine.Tests;

public class Tests
{
    private readonly Solution _solution = new();

    [Test]
    public void Test1()
    {
        int[][] coordinates =
            { new[] { 1, 2 }, new[] { 2, 3 }, new[] { 3, 4 }, new[] { 4, 5 }, new[] { 5, 6 }, new[] { 6, 7 } };
        const bool result = true;

        Assert.That(_solution.CheckStraightLine(coordinates), Is.EqualTo(result));
    }

    [Test]
    public void Test2()
    {
        int[][] coordinates =
            { new[] { 1, 1 }, new[] { 2, 2 }, new[] { 3, 4 }, new[] { 4, 5 }, new[] { 5, 6 }, new[] { 7, 7 } };
        const bool result = false;

        Assert.That(_solution.CheckStraightLine(coordinates), Is.EqualTo(result));
    }

    [Test]
    public void Test3()
    {
        int[][] coordinates = { new[] { 1, 2 }, new[] { 3, 5 }, new[] { 5, 8 } };
        const bool result = true;

        Assert.That(_solution.CheckStraightLine(coordinates), Is.EqualTo(result));
    }

    [Test]
    public void Test4()
    {
        int[][] coordinates = { new[] { 0, 0 }, new[] { 0, 5 }, new[] { 5, 5 }, new[] { 5, 0 } };
        const bool result = false;

        Assert.That(_solution.CheckStraightLine(coordinates), Is.EqualTo(result));
    }
}