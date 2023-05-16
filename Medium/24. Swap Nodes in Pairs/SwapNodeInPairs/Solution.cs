namespace SwapNodeInPairs;

public class Solution
{
    public ListNode SwapPairs(ListNode head)
    {
        if (head?.next == null)
            return head!;

        ListNode dummy = new(0) { next = head };
        ListNode curr = dummy;

        while (curr.next?.next != null)
        {
            ListNode first = curr.next;
            ListNode second = curr.next.next;
            
            curr.next = second;
            first.next = second.next;
            second.next = first;
            
            curr = curr.next.next!;
        }

        return dummy.next;
    }
}