namespace BinaryTreePreorderTraversal.Tests;

public class SolutionTests
{
    [Test]
    public void Test1()
    {
        TreeNode root = new(1);
        TreeNode rightNode1 = new(2);
        TreeNode rightNode2 = new(3);

        root.right = rightNode1;
        rightNode1.right = rightNode2;

        List<int> result = new() { 1, 2, 3 };
        
        Assert.That(new Solution().PreorderTraversal(root), Is.EqualTo(result));
    }
}