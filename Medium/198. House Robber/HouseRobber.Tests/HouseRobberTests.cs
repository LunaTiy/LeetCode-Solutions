namespace HouseRobber.Tests;

public class Tests
{
    private Solution _solution = null!;
    
    [SetUp]
    public void Setup()
    {
        _solution = new Solution();
    }

    [Test]
    public void Test1()
    {
        int[] nums = { 1, 2, 3, 1 };

        Assert.That(_solution.Rob(nums), Is.EqualTo(4));
    }
    
    [Test]
    public void Test2()
    {
        int[] nums = { 2,7,9,3,1 };

        Assert.That(_solution.Rob(nums), Is.EqualTo(12));
    }
}