namespace RemoveStonesToMinimizeTheTotal;

public class Solution
{
    public int MinStoneSum(int[] piles, int k)
    {
        var priorityQueue = new PriorityQueue<int, int>();
        var sum = 0;
        
        foreach (int pile in piles)
        {
            sum += pile;
            priorityQueue.Enqueue(pile, -pile);
        }

        for (var i = 0; i < k; i++)
        {
            int maxValue = priorityQueue.Dequeue();
            int sub = maxValue / 2;
            
            sum -= sub;
            priorityQueue.Enqueue(maxValue - sub, - (maxValue - sub));
        }

        return sum;
    }
}