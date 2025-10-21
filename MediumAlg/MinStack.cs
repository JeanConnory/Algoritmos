namespace MediumAlg;

public class MinStack
{
    private Stack<Tuple<int, int>> stack;

    public MinStack()
    {
        stack = new Stack<Tuple<int, int>>();
    }

    public void Push(int val)
    {
        int curMin = val;
        if (stack.Count > 0)
        {
            var lastElement = stack.Peek();
            curMin = Math.Min(curMin, lastElement.Item2);
        }
        stack.Push(new Tuple<int, int>(val, curMin));
    }

    public void Pop()
    {
        stack.Pop();
    }

    public int Top()
    {
        if (stack.Count == 0)
            return -1;
        var lastElement = stack.Peek();
        return lastElement.Item1;
    }

    public int GetMin()
    {
        if (stack.Count == 0)
            return -1;
        var lastElement = stack.Peek();
        return lastElement.Item2;
    }
}
