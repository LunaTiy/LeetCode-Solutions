namespace TwoSum.Tests;

public class Tests
{
    [Test]
    public void Test1()
    {
        const int target = 9;
        int[] array = { 2, 7, 11, 15};

        Assert.AreEqual(new[] { 0, 1 }, new Solution().TwoSum(array, target));
    }
    
    [Test]
    public void Test2()
    {
        const int target = 6;
        int[] array = { 3, 2, 4};

        Assert.AreEqual(new[] { 1, 2 }, new Solution().TwoSum(array, target));
    }
    
    [Test]
    public void Test3()
    {
        const int target = 6;
        int[] array = { 3, 3};

        Assert.AreEqual(new[] { 0, 1 }, new Solution().TwoSum(array, target));
    }
}