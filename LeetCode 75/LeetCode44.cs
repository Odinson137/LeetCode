using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace LeetCode44;

//Main();
//void Main()
//{
//    int[][] connections = new int[][]
//    {
//    new int[] {0, 1},
//    new int[] {1, 3},
//    new int[] {2, 3},
//    new int[] {4, 0},
//    new int[] {4, 5}
//    };


//    int n = 5;
//    Solution a = new Solution();
//    var value = a.MinReorder(n, connections);

//    Console.WriteLine(value);

//}


public class Solution
{
    public int MinReorder(int n, int[][] connections)
    {
        Dictionary<int, List<Tuple<int, int>>> graph = new Dictionary<int, List<Tuple<int, int>>>();
        foreach (var connection in connections)
        {
            if (!graph.ContainsKey(connection[0]))
                graph[connection[0]] = new List<Tuple<int, int>>();
            if (!graph.ContainsKey(connection[1]))
                graph[connection[1]] = new List<Tuple<int, int>>();
            graph[connection[0]].Add(Tuple.Create(connection[1], 1));
            graph[connection[1]].Add(Tuple.Create(connection[0], 0));
        }

        List<int> been = new List<int>();
        int reverse = Cycle(0, graph, 0, been);
        return reverse;
    }

    public static int Cycle(int index, Dictionary<int, List<Tuple<int, int>>> graph, int reverse, List<int> been)
    {
        been.Add(index);
        if (graph.ContainsKey(index))
        {
            foreach (var g in graph[index])
            {
                if (!been.Contains(g.Item1))
                {
                    if (g.Item2 == 1)
                    {
                        reverse++;
                    }
                    reverse = Cycle(g.Item1, graph, reverse, been);
                }
            }
        }

        return reverse;
    }
}