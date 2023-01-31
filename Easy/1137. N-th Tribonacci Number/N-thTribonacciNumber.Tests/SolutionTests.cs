namespace N_thTribonacciNumber.Tests;

public class SolutionTests
{
    [Test]
    public void Test1()
    {
        const int n = 4;
        const int result = 4;
        
        Assert.AreEqual(result, new Solution().Tribonacci(n));
    }
    
    [Test]
    public void Test2()
    {
        const int n = 25;
        const int result = 1389537;
        
        Assert.AreEqual(result, new Solution().Tribonacci(n));
    }
}