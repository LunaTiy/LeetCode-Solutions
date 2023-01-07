namespace GasStation.Tests;

public class SolutionTests
{
    [Test]
    public void Test1()
    {
        int[] gas = { 1, 2, 3, 4, 5 };
        int[] cost = { 3, 4, 5, 1, 2 };

        const int result = 3;
        
        Assert.AreEqual(result, new Solution().CanCompleteCircuit(gas, cost));
    }
    
    [Test]
    public void Test2()
    {
        int[] gas = { 2, 3, 4 };
        int[] cost = { 3, 4, 3 };

        const int result = -1;
        
        Assert.AreEqual(result, new Solution().CanCompleteCircuit(gas, cost));
    }
}