namespace MergeKSortedLists;

public class Solution
{
    public ListNode MergeKLists(ListNode[] lists)
    {
        List<int> mergedList = new();

        foreach (ListNode parentNode in lists)
        {
            ListNode currentNode = parentNode;

            while (currentNode != null)
            {
                mergedList.Add(currentNode.val);

                if (currentNode.next == null)
                    break;
                
                currentNode = currentNode.next;
            }
        }

        if (mergedList.Count == 0)
            return null!;
        
        mergedList.Sort();
        
        return GetNewNode(mergedList);
    }

    private static ListNode GetNewNode(List<int> list)
    {
        ListNode node = new(list[^1]);
        
        for (int i = list.Count - 2; i >= 0; i--)
            node = new ListNode(list[i], node);

        return node;
    }
}