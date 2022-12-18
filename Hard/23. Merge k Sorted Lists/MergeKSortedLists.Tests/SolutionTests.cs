namespace MergeKSortedLists.Tests;

public class SolutionTests
{
    [Test]
    public void Test1()
    {
        ListNode node3 = new(5);
        ListNode node2 = new(4, node3);
        ListNode node1 = new(1, node2);

        ListNode node6 = new(4);
        ListNode node5 = new(3, node6);
        ListNode node4 = new(1, node5);

        ListNode node8 = new(6);
        ListNode node7 = new(2, node8);

        ListNode[] list = { node1, node4, node7 };

        Assert.AreEqual(node1.val, new Solution().MergeKLists(list).val);
    }
    
    [Test]
    public void NullTest()
    {
        Assert.AreEqual(null, new Solution().MergeKLists(Array.Empty<ListNode>()));
        Assert.AreEqual(null, new Solution().MergeKLists(new ListNode[1]));
    }
}