namespace StringCompression.Tests;

public class Tests
{
    private readonly Solution _solution = new();
    
    [Test]
    public void Test1()
    {
        char[] chars = { 'a', 'a', 'b', 'b', 'c', 'c', 'c' };
        const int result = 6;

        int myResult = _solution.Compress(chars);
        Assert.That(myResult, Is.EqualTo(result));
    }
    
    [Test]
    public void Test2()
    {
        char[] chars = { 'a' };
        const int result = 1;
        
        Assert.That(_solution.Compress(chars), Is.EqualTo(result));
    }
    
    [Test]
    public void Test3()
    {
        char[] chars = { 'a', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b'};
        const int result = 4;
        
        Assert.That(_solution.Compress(chars), Is.EqualTo(result));
    }
}