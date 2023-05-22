namespace GreatestCommonDivisorOfStrings.Tests;

public class SolutionTests
{
    private readonly Solution _solution = new();

    [Test]
    public void Test1()
    {
        const string str1 = "ABCABC";
        const string str2 = "ABC";
        const string result = "ABC";

        Assert.That(_solution.GcdOfStrings(str1, str2), Is.EqualTo(result));
    }
    
    [Test]
    public void Test2()
    {
        const string str1 = "ABABAB";
        const string str2 = "ABAB";
        const string result = "AB";

        Assert.That(_solution.GcdOfStrings(str1, str2), Is.EqualTo(result));
    }

    [Test]
    public void Test3()
    {
        const string str1 = "LEET";
        const string str2 = "CODE";
        const string result = "";

        Assert.That(_solution.GcdOfStrings(str1, str2), Is.EqualTo(result));
    }

}