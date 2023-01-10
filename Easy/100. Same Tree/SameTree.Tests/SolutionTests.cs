namespace SameTree.Tests;

public class SolutionTests
{
    [Test]
    public void Test1()
    {
        TreeNode left1 = new(2);
        TreeNode right1 = new(3);
        TreeNode root1 = new(1, left1, right1);
        
        TreeNode left2 = new(2);
        TreeNode right2 = new(3);
        TreeNode root2 = new(1, left2, right2);
        
        Assert.That(new Solution().IsSameTree(root1, root2), Is.EqualTo(true));
    }
    
    [Test]
    public void Test2()
    {
        TreeNode left1 = new(2);
        TreeNode root1 = new(1, left1);
        
        TreeNode right2 = new(2);
        TreeNode root2 = new(1, null!, right2);
        
        Assert.That(new Solution().IsSameTree(root1, root2), Is.EqualTo(false));
    }
    
    [Test]
    public void Test3()
    {
        TreeNode left1 = new(2);
        TreeNode right1 = new(1);
        TreeNode root1 = new(1, left1, right1);
        
        TreeNode left2 = new(1);
        TreeNode right2 = new(2);
        TreeNode root2 = new(1, left2, right2);
        
        Assert.That(new Solution().IsSameTree(root1, root2), Is.EqualTo(false));
    }
}