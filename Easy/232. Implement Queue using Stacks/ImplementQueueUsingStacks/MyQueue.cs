namespace ImplementQueueUsingStacks;

public class MyQueue
{
    private readonly List<int> _queue;
    
    public MyQueue()
    {
        _queue = new List<int>();
    }

    public void Push(int x) => _queue.Add(x);

    public int Pop()
    {
        if (Empty())
            return 0;

        var value = _queue[0];
        _queue.RemoveAt(0);

        return value;
    }

    public int Peek() => Empty() ? 0 : _queue[0];

    public bool Empty() => _queue.Count == 0;
}