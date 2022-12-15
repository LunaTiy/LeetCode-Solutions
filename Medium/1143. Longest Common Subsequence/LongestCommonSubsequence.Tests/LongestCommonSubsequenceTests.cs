namespace LongestCommonSubsequence.Tests;

public class Tests
{
    private Solution _solution = null!;
    
    [SetUp]
    public void Setup()
    {
        _solution = new Solution();
    }

    [Test]
    public void Test1()
    {
        Assert.That(_solution.LongestCommonSubsequence("abcde", "ace"), Is.EqualTo(3));
    }
    
    [Test]
    public void Test2()
    {
        Assert.That(_solution.LongestCommonSubsequence("abc", "abc"), Is.EqualTo(3));
    }
    
    [Test]
    public void Test3()
    {
        Assert.That(_solution.LongestCommonSubsequence("abc", "def"), Is.EqualTo(0));
    }
    
    [Test]
    public void Test4()
    {
        Assert.That(_solution.LongestCommonSubsequence("ezupkr", "ubmrapg"), Is.EqualTo(2));
    }
    
    [Test]
    public void Test5()
    {
        Assert.That(_solution.LongestCommonSubsequence("mhunuzqrkzsnidwbun", "szulspmhwpazoxijwbq"), Is.EqualTo(6));
    }
}