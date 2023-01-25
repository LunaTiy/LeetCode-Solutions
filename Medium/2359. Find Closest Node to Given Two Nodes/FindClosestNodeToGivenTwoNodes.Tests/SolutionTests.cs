namespace FindClosestNodeToGivenTwoNodes.Tests;

public class SolutionTests
{
    [Test]
    public void Test1()
    {
        int[] edges = { 2, 2, 3, -1 };
        const int node1 = 0;
        const int node2 = 1;
        const int result = 2;
        
        Assert.AreEqual(result, new Solution().ClosestMeetingNode(edges, node1, node2));
    }
    
    [Test]
    public void Test2()
    {
        int[] edges = { 1, 2, -1 };
        const int node1 = 0;
        const int node2 = 2;
        const int result = 2;
        
        Assert.AreEqual(result, new Solution().ClosestMeetingNode(edges, node1, node2));
    }
    
    [Test]
    public void Test3()
    {
        int[] edges = { 4, 3, 0, 5, 3, -1 };
        const int node1 = 4;
        const int node2 = 0;
        const int result = 4;
        
        Assert.AreEqual(result, new Solution().ClosestMeetingNode(edges, node1, node2));
    }
}