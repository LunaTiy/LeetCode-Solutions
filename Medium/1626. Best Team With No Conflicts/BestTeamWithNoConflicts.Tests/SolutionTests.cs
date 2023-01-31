namespace BestTeamWithNoConflicts.Tests;

public class SolutionTests
{
    [Test]
    public void Test1()
    {
        int[] scores = { 1, 3, 5, 10, 15 };
        int[] ages = { 1, 2, 3, 4, 5 };
        const int result = 34;
        
        Assert.AreEqual(result, new Solution().BestTeamScore(scores, ages));
    }
    
    [Test]
    public void Test2()
    {
        int[] scores = { 4, 5, 6, 5 };
        int[] ages = { 2, 1, 2, 1 };
        const int result = 16;
        
        Assert.AreEqual(result, new Solution().BestTeamScore(scores, ages));
    }
    
    [Test]
    public void Test3()
    {
        int[] scores = { 1, 2, 3, 5 };
        int[] ages = { 8, 9, 10, 1 };
        const int result = 6;
        
        Assert.AreEqual(result, new Solution().BestTeamScore(scores, ages));
    }
}