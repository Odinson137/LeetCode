using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode21;

public class Solution
{
    public static bool UniqueOccurrences(int[] arr)
    {
        Dictionary<int, int> unique = new Dictionary<int, int>();
        foreach (int i in arr)
            if (!unique.TryAdd(i, 0))
                unique[i] += 1;

        var list = unique.Values;
        if (list.Count() == list.ToHashSet().Count())
            return true;
        return false;
    }

    //public static void Main()
    //{
    //    int[] arr = new int[]
    //    {
    //        -3,0,1,-3,1,1,1,-3,10,0
    //    };

    //    var value = UniqueOccurrences(arr);
    //    Console.WriteLine(value);
    //}
}
