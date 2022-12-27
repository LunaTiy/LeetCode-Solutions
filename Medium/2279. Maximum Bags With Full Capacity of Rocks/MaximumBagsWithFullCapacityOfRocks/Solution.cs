namespace MaximumBagsWithFullCapacityOfRocks;

public class Solution
{
    public int MaximumBags(int[] capacity, int[] rocks, int additionalRocks)
    {
        if (capacity.Length == 0 || rocks.Length == 0)
            return 0;
        
        for (var i = 0; i < capacity.Length; i++)
        {
            int newCapacity = capacity[i] - rocks[i];
            capacity[i] = newCapacity < 0 ? 0 : newCapacity;
        }

        if (additionalRocks == 0)
            return capacity.Count(x => x == 0);

        int[] bagsWithFreeSlots = capacity.Where(x => x != 0).ToArray();
        Array.Sort(bagsWithFreeSlots);
        
        int countFullBags = capacity.Length - bagsWithFreeSlots.Length;

        var currentBag = 0;
        
        while (additionalRocks > 0 && currentBag < bagsWithFreeSlots.Length)
        {
            if (bagsWithFreeSlots[currentBag] > additionalRocks)
                break;

            int capacityCurrentBag = bagsWithFreeSlots[currentBag];
            bagsWithFreeSlots[currentBag] = 0;
            additionalRocks -= capacityCurrentBag;
            countFullBags++;
            
            currentBag++;
        }

        return countFullBags;
    }
}