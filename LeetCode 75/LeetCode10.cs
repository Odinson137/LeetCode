using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode10;

public class Solution
{
    public static void MoveZeroes(int[] nums)
    {
        int n = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                (nums[i], nums[n]) = (nums[n], nums[i]);
                n++;
            }
        }

    }

    //public static void MoveZeroes(int[] nums)
    //{
    //    int[] newNums = new int[nums.Length];

    //    int n = 0;
    //    for (int i = 0; i < nums.Length; i++)
    //    {
    //        if (nums[i] != 0)
    //        {
    //            newNums[n++] = nums[i];
    //        }
    //    }

    //    for (int i = 0; i < nums.Length; i++)
    //    {
    //        nums[i] = newNums[i];
    //    }
    //}

    //public static void Main()
    //{
    //    int[] chars = new int[] {
    //        0,1,0,3,12
    //    };

    //    MoveZeroes(chars);
    //    Console.WriteLine();
    //}

}
