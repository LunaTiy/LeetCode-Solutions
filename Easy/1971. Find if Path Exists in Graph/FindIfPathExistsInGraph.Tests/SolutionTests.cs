namespace FindIfPathExistsInGraph.Tests;

public class SolutionTests
{
    [Test]
    public void Test1()
    {
        Assert.That(
            new Solution().ValidPath(3, new[] { new[] { 0, 1 }, new[] { 1, 2 }, new[] { 2, 0 } }, 0, 2),
            Is.EqualTo(true));
    }
}