namespace PossibleBipartition.Tests;

public class SolutionTests
{
    [Test]
    public void Test1()
    {
        int[][] dislikes = { new[] { 1, 2 }, new[] { 1, 3 }, new[] { 2, 4 } };
        Assert.That(new Solution().PossibleBipartition(4, dislikes), Is.EqualTo(true));
    }
    
    [Test]
    public void Test2()
    {
        int[][] dislikes = { new[] { 1, 2 }, new[] { 1, 3 }, new[] { 2, 3 } };
        Assert.That(new Solution().PossibleBipartition(3, dislikes), Is.EqualTo(false));
    }
    
    [Test]
    public void Test3()
    {
        int[][] dislikes = { new[] { 1, 2 }, new[] { 2, 3 }, new[] { 3, 4 }, new[] { 4, 5 }, new[] { 1, 5 } };
        Assert.That(new Solution().PossibleBipartition(5, dislikes), Is.EqualTo(false));
    }
}