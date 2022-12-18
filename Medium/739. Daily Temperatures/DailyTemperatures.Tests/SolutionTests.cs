namespace DailyTemperatures.Tests;

public class SolutionTests
{
    [Test]
    public void Test1()
    {
        int[] temperatures = { 73, 74, 75, 71, 69, 72, 76, 73 };
        int[] result = { 1,1,4,2,1,1,0,0 };
        
        Assert.AreEqual(result, new Solution().DailyTemperatures(temperatures));
    }
    
    [Test]
    public void Test2()
    {
        int[] temperatures = { 30,40,50,60 };
        int[] result = { 1,1,1,0 };
        
        Assert.AreEqual(result, new Solution().DailyTemperatures(temperatures));
    }
    
    [Test]
    public void Test3()
    {
        int[] temperatures = { 30,60,90 };
        int[] result = { 1,1,0 };
        
        Assert.AreEqual(result, new Solution().DailyTemperatures(temperatures));
    }
}