namespace WordPattern.Tests;

public class SolutionTests
{
    [Test]
    public void Test1()
    {
        var pattern = "abba";
        var s = "dog cat cat dog";
        
        Assert.AreEqual(true, new Solution().WordPattern(pattern, s));
    }
    
    [Test]
    public void Test2()
    {
        var pattern = "abba";
        var s = "dog cat cat fish";
        
        Assert.AreEqual(false, new Solution().WordPattern(pattern, s));
    }
    
    [Test]
    public void Test3()
    {
        var pattern = "aaaa";
        var s = "dog cat cat dog";
        
        Assert.AreEqual(false, new Solution().WordPattern(pattern, s));
    }
    
    [Test]
    public void Test4()
    {
        var pattern = "abba";
        var s = "dog dog dog dog";
        
        Assert.AreEqual(false, new Solution().WordPattern(pattern, s));
    }
    
    [Test]
    public void Test5()
    {
        var pattern = "aaa";
        var s = "aa aa aa aa";
        
        Assert.AreEqual(false, new Solution().WordPattern(pattern, s));
    }
}