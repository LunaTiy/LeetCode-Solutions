namespace IncreasingTripletSubsequence.Tests;

public class Tests
{
    private readonly Solution _solution = new();

    [Test]
    public void Test1()
    {
        int[] nums = { 1, 2, 3, 4, 5 };
        const bool result = true;
        
        Assert.That(_solution.IncreasingTriplet(nums), Is.EqualTo(result));
    }
    
    [Test]
    public void Test2()
    {
        int[] nums = { 5, 4, 3, 2, 1 };
        const bool result = false;
        
        Assert.That(_solution.IncreasingTriplet(nums), Is.EqualTo(result));
    }
    
    [Test]
    public void Test3()
    {
        int[] nums = { 2, 1, 5, 0, 4, 6 };
        const bool result = true;
        
        Assert.That(_solution.IncreasingTriplet(nums), Is.EqualTo(result));
    }
    
    [Test]
    public void Test4()
    {
        int[] nums = { 2, 1, 5, 0, 6 };
        const bool result = true;
        
        Assert.That(_solution.IncreasingTriplet(nums), Is.EqualTo(result));
    }
}