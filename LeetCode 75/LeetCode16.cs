using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode16;

public class Solution
{
    public static int LongestOnes(int[] nums, int k)
    {
        int maxLen = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            int n = 0;
            int a = i;
            int intK = 0;
            while (a < nums.Length)
            {
                if (nums[a] == 0)
                {
                    intK++;
                    if (intK > k)
                    {
                        break;
                    }
                }
                n++;
                a++;
            }
            if (n > maxLen) maxLen = n;

        }

        return maxLen;
    }

    //public static void Main()
    //{
    //    int[] nums = new int[]
    //    {
    //        0, 0, 0, 1
    //    };
    //    int k = 4;

    //    int value = LongestOnes(nums, k);
    //    Console.WriteLine(value);
    //}
}