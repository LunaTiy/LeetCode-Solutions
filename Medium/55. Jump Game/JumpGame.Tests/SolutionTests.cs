namespace JumpGame.Tests;

public class SolutionTests
{
    [Test]
    public void Test1()
    {
        int[] nums = { 2, 3, 1, 1, 4 };
        Assert.That(new Solution().CanJump(nums), Is.EqualTo(true));
    }
    
    [Test]
    public void Test2()
    {
        int[] nums = { 3, 2, 1, 0, 4 };
        Assert.That(new Solution().CanJump(nums), Is.EqualTo(false));
    }
    
    [Test]
    public void Test3()
    {
        int[] nums = { 3, 0, 8, 2, 0, 0, 1 };
        Assert.That(new Solution().CanJump(nums), Is.EqualTo(true));
    }
}