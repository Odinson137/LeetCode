using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode18;

public class Solution
{
    public static int LargestAltitude(int[] gain)
    {
        for (int i = 1; i < gain.Length; i++)
            gain[i] += gain[i-1];

        return Math.Max(gain.Max(), 0);
    }

    //public static void Main()
    //{
    //    int[] gain = new int[]
    //    {
    //        -5,1,5,0,-7
    //    };

    //    int value = LargestAltitude(gain);
    //    Console.WriteLine(value);
    //}
}
