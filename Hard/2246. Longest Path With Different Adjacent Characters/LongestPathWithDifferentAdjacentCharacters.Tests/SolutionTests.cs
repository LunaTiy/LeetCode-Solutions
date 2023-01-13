namespace LongestPathWithDifferentAdjacentCharacters.Tests;

public class SolutionTests
{
    [Test]
    public void Test1()
    {
        int[] parent = { -1, 0, 0, 1, 1, 2 };
        const string s = "abacbe";
        
        const int result = 3;

        Assert.AreEqual(result, new Solution().LongestPath(parent, s));
    }
    
    [Test]
    public void Test2()
    {
        int[] parent = { -1, 0, 0, 0 };
        const string s = "aabc";
        
        const int result = 3;

        Assert.AreEqual(result, new Solution().LongestPath(parent, s));
    }
    
    [Test]
    public void Test3()
    {
        int[] parent = { -1, 0, 1 };
        const string s = "aab";
        
        const int result = 2;

        Assert.AreEqual(result, new Solution().LongestPath(parent, s));
    }
}