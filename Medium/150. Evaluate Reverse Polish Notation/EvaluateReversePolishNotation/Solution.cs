namespace EvaluateReversePolishNotation;

public class Solution
{
    public int EvalRPN(string[] tokens)
    {
        Stack<int> stack = new();

        foreach (string token in tokens)
        {
            if (token == "+")
                stack.Push(stack.Pop() + stack.Pop());
            else if (token == "-")
                stack.Push(-stack.Pop() + stack.Pop());
            else if (token == "/")
                stack.Push((int)(1.0D / stack.Pop() * stack.Pop()));
            else if (token == "*")
                stack.Push(stack.Pop() * stack.Pop());
            else
                stack.Push(int.Parse(token));
        }

        return stack.Pop();
    }
}