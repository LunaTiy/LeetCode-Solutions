namespace N_thTribonacciNumber;

public class Solution
{
    public int Tribonacci(int n)
    {
        if (n == 0)
            return 0;

        if (n == 1 || n == 2)
            return 1;
        
        var sequence = new Queue<int>(3);
        sequence.Enqueue(0);
        sequence.Enqueue(0);
        sequence.Enqueue(1);
        
        var result = sequence.Sum();
        
        for (var i = 2; i < n; i++)
        {
            int prevElement = sequence.Dequeue();
            sequence.Enqueue(result);

            result += result - prevElement;
        }
        
        return result;
    }
}