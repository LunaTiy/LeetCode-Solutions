namespace Minimum_Flips_to_Make_a_OR_b_Equal_to_c.Tests;

public class Tests
{
    private readonly Solution _solution = new();

    [Test]
    public void Test1()
    {
        const int a = 2;
        const int b = 6;
        const int c = 5;

        const int result = 3;
        Assert.That(_solution.MinFlips(a, b, c), Is.EqualTo(result));
    }
    
    [Test]
    public void Test2()
    {
        const int a = 4;
        const int b = 2;
        const int c = 7;

        const int result = 1;
        Assert.That(_solution.MinFlips(a, b, c), Is.EqualTo(result));
    }

    [Test]
    public void Test3()
    {
        const int a = 1;
        const int b = 2;
        const int c = 3;

        const int result = 0;
        Assert.That(_solution.MinFlips(a, b, c), Is.EqualTo(result));
    }
}