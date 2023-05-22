namespace MergeStringsAlternately.Tests;

public class SolutionTests
{
    private readonly Solution _solution = new Solution();
    
    [Test]
    public void Test1()
    {
        const string word1 = "abc";
        const string word2 = "pqr";

        const string result = "apbqcr";
        
        Assert.That(_solution.MergeAlternately(word1, word2), Is.EqualTo(result));
    }
    
    [Test]
    public void Test2()
    {
        const string word1 = "ab";
        const string word2 = "pqrs";

        const string result = "apbqrs";
        
        Assert.That(_solution.MergeAlternately(word1, word2), Is.EqualTo(result));
    }
    
    [Test]
    public void Test3()
    {
        const string word1 = "abcd";
        const string word2 = "pq";

        const string result = "apbqcd";
        
        Assert.That(_solution.MergeAlternately(word1, word2), Is.EqualTo(result));
    }

}