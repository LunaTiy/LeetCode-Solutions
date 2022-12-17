namespace EvaluateReversePolishNotation.Tests;

public class Tests
{
    [Test]
    public void Test1()
    {
        const int result = 9;
        string[] tokens = { "2", "1", "+", "3", "*" };

        Assert.AreEqual(result, new Solution().EvalRPN(tokens));
    }
    
    [Test]
    public void Test2()
    {
        const int result = 6;
        string[] tokens = { "4", "13", "5", "/", "+" };

        Assert.AreEqual(result, new Solution().EvalRPN(tokens));
    }
    
    [Test]
    public void Test3()
    {
        const int result = 22;
        string[] tokens = { "10", "6", "9", "3", "+", "-11", "*", "/", "17", "+", "5", "+" };

        Assert.AreEqual(result, new Solution().EvalRPN(tokens));
    }
    
    [Test]
    public void Test4()
    {
        const int result = 9;
        string[] tokens = { "3","11","+","5","-" };

        Assert.AreEqual(result, new Solution().EvalRPN(tokens));
    }
    
    [Test]
    public void Test5()
    {
        const int result = -13;
        string[] tokens = { "3","11","5","+","-" };

        Assert.AreEqual(result, new Solution().EvalRPN(tokens));
    }
    
    [Test]
    public void Test6()
    {
        const int result = -7;
        string[] tokens = { "4","-2","/","2","-3","-","-" };

        Assert.AreEqual(result, new Solution().EvalRPN(tokens));
    }
}