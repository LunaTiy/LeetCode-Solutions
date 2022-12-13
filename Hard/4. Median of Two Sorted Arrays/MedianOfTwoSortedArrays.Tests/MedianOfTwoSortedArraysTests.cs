namespace MedianOfTwoSortedArrays.Tests;

public class Tests
{
    [Test]
    public void Test1()
    {
        int[] array1 = { 1, 3 };
        int[] array2 = { 2 };
        
        Assert.AreEqual(2.0, new Solution().FindMedianSortedArrays(array1, array2));
    }
    
    [Test]
    public void Test2()
    {
        int[] array1 = { 1, 2 };
        int[] array2 = { 3, 4 };
        
        Assert.AreEqual(2.5, new Solution().FindMedianSortedArrays(array1, array2));
    }
}