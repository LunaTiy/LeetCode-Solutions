namespace BinaryTreePreorderTraversal;

public class Solution
{
    public IList<int> PreorderTraversal(TreeNode root)
    {
        List<int> order = new();
        
        if (root != null)
            GetNodeValue(order, root);
        
        return order;
    }

    private static void GetNodeValue(List<int> order, TreeNode root)
    {
        order.Add(root.val);
        
        if(root.left != null)
            GetNodeValue(order, root.left);
        
        if(root.right != null)
            GetNodeValue(order, root.right);
    }
}