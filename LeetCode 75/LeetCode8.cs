using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode8;

public class Solution
{
    public static bool IncreasingTriplet(int[] nums)
    {
 


        return false;
    }

    //public static void Recurs(List<int> nums, int s)
    //{
    //    //int min = nums.Min();
    //    //int index = nums.IndexOf(min);

    //    //int len = nums.Count() - index;
    //    //if (len != 0)
    //    //{
    //    //    List<int> newMas = nums.GetRange(len, nums.Count());
    //    //    Recurs(newMas, s++);

    //    //    //if (s == 3) return;
    //    //} 
    //    //else
    //    //{
    //    //    nums.Remove(min);
    //    //    Recurs();
    //    //}
    //    //if ((len) >= 4)
    //    //{



    //    //    if (s == 3)
    //    //    {
    //    //        return true;
    //    //    }
    //    //}
    //    //else return false;
    //}

    public static void Main()
    {
        int[] nums = new int[] { 20, 100, 10, 12, 5, 13 };
        bool value = IncreasingTriplet(nums);
        Console.WriteLine(value);
    }
}
