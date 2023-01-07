namespace GasStation;

public class Solution
{
    public int CanCompleteCircuit(int[] gas, int[] cost)
    {
        var totalGas = 0;
        var totalCost = 0;
        var currentGas = 0;
        
        var startingPoint = 0;

        for (var i = 0; i < gas.Length; i++)
        {
            totalGas += gas[i];
            totalCost += cost[i];

            currentGas += gas[i] - cost[i];

            if (currentGas >= 0) continue;
            
            startingPoint = i + 1;
            currentGas = 0;
        }

        return totalGas < totalCost ? -1 : startingPoint;
    }
}