namespace ReverseWordsInString.Tests;

public class Tests
{
    private readonly Solution _solution = new();

    [Test]
    public void Test1()
    {
        const string s = "the sky is blue";
        const string result = "blue is sky the";
        
        Assert.That(_solution.ReverseWords(s), Is.EqualTo(result));
    }
    
    [Test]
    public void Test2()
    {
        const string s = "  hello world  ";
        const string result = "world hello";
        
        Assert.That(_solution.ReverseWords(s), Is.EqualTo(result));
    }

    [Test]
    public void Test3()
    {
        const string s = "a good   example";
        const string result = "example good a";
        
        Assert.That(_solution.ReverseWords(s), Is.EqualTo(result));
    }
}