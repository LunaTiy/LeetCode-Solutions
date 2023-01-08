namespace FindXor_BeautyOfArray;

public class Solution
{
    public int XorBeauty(int[] nums) => nums.Aggregate(0, (current, num) => current ^ num);
}