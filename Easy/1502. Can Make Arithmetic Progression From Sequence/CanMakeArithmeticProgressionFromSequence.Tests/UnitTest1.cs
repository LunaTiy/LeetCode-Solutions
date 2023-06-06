namespace CanMakeArithmeticProgressionFromSequence.Tests;

public class Tests
{
    private readonly Solution _solution = new();

    [Test]
    public void Test1()
    {
        int[] arr = { 3, 5, 1 };
        const bool result = true;
        
        Assert.That(_solution.CanMakeArithmeticProgression(arr), Is.EqualTo(result));
    }
    
    [Test]
    public void Test2()
    {
        int[] arr = { 1, 2, 4 };
        const bool result = false;
        
        Assert.That(_solution.CanMakeArithmeticProgression(arr), Is.EqualTo(result));
    }
}