namespace SwapNodeInPairs.Tests;

public class SolutionTests
{
    private Solution _solution = new();
        
    [Test]
    public void Test1()
    {
        ListNode tail = new(4);
        ListNode node2 = new(3, tail);
        ListNode node1 = new(2, node2);
        ListNode? head = new(1, node1);
        
        ListNode tailResult = new(3);
        ListNode nodeResult2 = new(4, tailResult);
        ListNode nodeResult1 = new(1, nodeResult2);
        ListNode headResult = new(2, nodeResult1);
        
        Assert.That(_solution.SwapPairs(head), Is.EqualTo(headResult));
    }
}