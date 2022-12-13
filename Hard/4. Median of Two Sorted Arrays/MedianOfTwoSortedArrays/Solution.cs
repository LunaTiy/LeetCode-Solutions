namespace MedianOfTwoSortedArrays;

public class Solution
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        if(nums1.Length == 0)
            return GetMedian(nums2);

        if(nums2.Length == 0)
            return GetMedian(nums1);

        int[] resultArray = nums1.Concat(nums2).ToArray();
        Array.Sort(resultArray);

        return GetMedian(resultArray);
    }

    private double GetMedian(int[] array)
    {
        if(array.Length == 0)
            return 0;

        int mediumIndex = array.Length / 2;
        
        if(array.Length % 2 == 1)
            return array[mediumIndex];
        
        return (double)(array[mediumIndex - 1] + array[mediumIndex]) / 2;
    }
}