namespace KidsWithTheGreatestNumberOfCandies.Tests;

public class SolutionTests
{
    private readonly Solution _solution = new();
    
    [Test]
    public void Test1()
    {
        int[] candies = { 2, 3, 5, 1, 3 };
        const int extraCandies = 3;
        
        bool[] result = { true, true, true, false, true };

        Assert.That(_solution.KidsWithCandies(candies, extraCandies), Is.EqualTo(result));
    }
    
    [Test]
    public void Test2()
    {
        int[] candies = { 4, 2, 1, 1, 2 };
        const int extraCandies = 1;
        
        bool[] result = { true, false, false, false, false };

        Assert.That(_solution.KidsWithCandies(candies, extraCandies), Is.EqualTo(result));
    }

    [Test]
    public void Test3()
    {
        int[] candies = { 12, 1, 12 };
        const int extraCandies = 10;
        
        bool[] result = { true, false, true };

        Assert.That(_solution.KidsWithCandies(candies, extraCandies), Is.EqualTo(result));
    }
}