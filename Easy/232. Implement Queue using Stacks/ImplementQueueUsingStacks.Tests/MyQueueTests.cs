namespace ImplementQueueUsingStacks.Tests;

public class Tests
{
    [Test]
    public void Test1()
    {
        MyQueue myQueue = new();
        
        myQueue.Push(1);
        myQueue.Push(2);
        
        Assert.Multiple(() =>
        {
            Assert.That(myQueue.Peek(), Is.EqualTo(1));
            Assert.That(myQueue.Pop(), Is.EqualTo(1));
            Assert.That(myQueue.Empty, Is.EqualTo(false));
        });
    }
}