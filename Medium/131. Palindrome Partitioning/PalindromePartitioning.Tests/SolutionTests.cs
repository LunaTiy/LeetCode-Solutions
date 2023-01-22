namespace PalindromePartitioning.Tests;

public class SolutionTests
{
    [Test]
    public void Test1()
    {
        const string s = "aab";
        List<List<string>> result = new() { new List<string> { "a", "a", "b" }, new List<string> { "aa", "b" } };
        
        Assert.AreEqual(result, new Solution().Partition(s));
    }
    
    [Test]
    public void Test2()
    {
        const string s = "a";
        List<List<string>> result = new() { new List<string> { "a" } };
        
        Assert.AreEqual(result, new Solution().Partition(s));
    }
}