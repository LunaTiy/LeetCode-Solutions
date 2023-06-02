namespace ProductOfArrayExceptSelf.Tests;

public class Tests
{
    private readonly Solution _solution = new();

    [Test]
    public void Test1()
    {
        int[] nums = { 1, 2, 3, 4 };
        int[] result = { 24, 12, 8, 6 };
        
        Assert.That(_solution.ProductExceptSelf(nums), Is.EqualTo(result));
    }
    
    [Test]
    public void Test2()
    {
        int[] nums = { -1, 1, 0, -3, 3 };
        int[] result = { 0, 0, 9, 0, 0 };
        
        Assert.That(_solution.ProductExceptSelf(nums), Is.EqualTo(result));
    }
}