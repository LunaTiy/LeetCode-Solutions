namespace FlipStringToMonotoneIncreasing.Tests;

public class SolutionTests
{
    [Test]
    public void Test1()
    {
        const string s = "00110";
        const int result = 1;
        
        Assert.That(new Solution().MinFlipsMonoIncr(s), Is.EqualTo(result));
    }
    
    [Test]
    public void Test2()
    {
        const string s = "010110";
        const int result = 2;
        
        Assert.That(new Solution().MinFlipsMonoIncr(s), Is.EqualTo(result));
    }
    
    [Test]
    public void Test3()
    {
        const string s = "00011000";
        const int result = 2;
        
        Assert.That(new Solution().MinFlipsMonoIncr(s), Is.EqualTo(result));
    }
    
    [Test]
    public void Test4()
    {
        const string s = "111011100100100";
        const int result = 7;
        
        Assert.That(new Solution().MinFlipsMonoIncr(s), Is.EqualTo(result));
    }
}