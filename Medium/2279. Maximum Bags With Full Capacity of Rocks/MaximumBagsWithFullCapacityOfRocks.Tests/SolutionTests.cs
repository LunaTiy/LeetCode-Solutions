namespace MaximumBagsWithFullCapacityOfRocks.Tests;

public class SolutionTests
{
    [Test]
    public void Test1()
    {
        int[] capacity = { 2, 3, 4, 5 };
        int[] rocks = { 1, 2, 4, 4 };
        
        const int additionalRocks = 2;
        const int result = 3;

        Assert.AreEqual(result, new Solution().MaximumBags(capacity, rocks, additionalRocks));
    }
}