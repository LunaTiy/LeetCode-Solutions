namespace ReverseVowelsOfString.Tests;

public class SolutionTests
{
    private readonly Solution _solution = new();
    
    [Test]
    public void Test1()
    {
        const string s = "hello";
        const string result = "holle";
        
        Assert.That(_solution.ReverseVowels(s), Is.EqualTo(result));
    }
    
    [Test]
    public void Test2()
    {
        const string s = "leetcode";
        const string result = "leotcede";
        
        Assert.That(_solution.ReverseVowels(s), Is.EqualTo(result));
    }
}