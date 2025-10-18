namespace EasyAlg;

public class RecentCounter
{
    Queue<int> q = new Queue<int>();

    public RecentCounter()
    {        
    }

    public int Ping(int t)
    {
        int val = t - 3000;
        q.Enqueue(t);

        while (q.Peek() < val)
        {
            q.Dequeue();
        }

        return q.Count;
    }
}
