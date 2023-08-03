using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//RecentCounter recentCounter = new RecentCounter();
//int[] mas = new int[]
//{
//    1, 100, 3001, 3002
//};

//foreach (int i in mas)
//{
//    int value = recentCounter.Ping(i);
//    Console.WriteLine(value);
//}

public class RecentCounter
{
    Queue<int> Queue;

    public RecentCounter()
    {
        Queue = new Queue<int>();
    }

    public int Ping(int t)
    {
        Queue.Enqueue(t);

        while (t - Queue.Peek() > 3000)
            Queue.Dequeue();

        return Queue.Count;
    }
}

