namespace ConcatenatedWords.Tests;

public class SolutionTests
{
    [Test]
    public void Test1()
    {
        string[] words = { "cat", "cats", "catsdogcats", "dog", "dogcatsdog", "hippopotamuses", "rat", "ratcatdogcat" };
        string[] result = { "catsdogcats", "dogcatsdog", "ratcatdogcat" };

        Assert.AreEqual(result, new Solution().FindAllConcatenatedWordsInADict(words));
    }

    [Test]
    public void Test2()
    {
        string[] words = { "cat", "dog", "catdog" };
        string[] result = { "catdog" };

        Assert.AreEqual(result, new Solution().FindAllConcatenatedWordsInADict(words));
    }
}