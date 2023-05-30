namespace CanPlaceFlowers.Tests;

public class SolutionTests
{
    private readonly Solution _solution = new();
    
    [Test]
    public void Test1()
    {
        int[] flowerbed = { 1, 0, 0, 0, 1 };
        const int n = 1;

        const bool result = true;
        Assert.That(_solution.CanPlaceFlowers(flowerbed, n), Is.EqualTo(result));
    }
    
    [Test]
    public void Test2()
    {
        int[] flowerbed = { 1, 0, 0, 0, 1 };
        const int n = 2;

        const bool result = false;
        Assert.That(_solution.CanPlaceFlowers(flowerbed, n), Is.EqualTo(result));
    }

    [Test]
    public void Test3()
    {
        int[] flowerbed = { 1, 0, 1, 0, 1, 0, 1 };
        const int n = 1;

        const bool result = false;
        Assert.That(_solution.CanPlaceFlowers(flowerbed, n), Is.EqualTo(result));
    }
}