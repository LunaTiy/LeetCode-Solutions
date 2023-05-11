namespace UncrossedLines.Tests;

public class SolutionTests
{
    private Solution _solution = new();

    [Test]
    public void Test1()
    {
        int[] nums1 = { 1, 4, 2 };
        int[] nums2 = { 1, 2 ,4 };

        const int result = 2;
        
        Assert.That(_solution.MaxUncrossedLines(nums1, nums2), Is.EqualTo(result));
    }

    [Test]
    public void Test2()
    {
        int[] nums1 = { 2, 5, 1, 2, 5 };
        int[] nums2 = { 10, 5, 2, 1, 5, 2 };

        const int result = 3;
        
        Assert.That(_solution.MaxUncrossedLines(nums1, nums2), Is.EqualTo(result));
    }
}