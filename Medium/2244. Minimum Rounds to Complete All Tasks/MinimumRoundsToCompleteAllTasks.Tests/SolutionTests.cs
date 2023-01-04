namespace MinimumRoundsToCompleteAllTasks.Tests;

public class SolutionTests
{
    [Test]
    public void Test1()
    {
        int[] tasks = { 2, 2, 3, 3, 2, 4, 4, 4, 4, 4 };
        
        Assert.AreEqual(4, new Solution().MinimumRounds(tasks));
    }
    
    [Test]
    public void Test2()
    {
        int[] tasks = { 2, 3, 3 };
        
        Assert.AreEqual(-1, new Solution().MinimumRounds(tasks));
    }
}