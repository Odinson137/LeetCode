using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode17;

public class Solution
{

    //public static int LongestSubarray(int[] nums)
    //{
    //    int max = 0;
    //    int n = 0;
    //    int left = 0;
    //    int zero = 0;
    //    int i = 0;
    //    while (i < nums.Length)
    //    {
    //        if (nums[i] == 1)
    //        {
    //            n++;
    //            left++;
    //        }
    //        else
    //        {
    //            if (zero == 1)
    //            {
    //                max = Math.Max(max, left);
    //                left = 0;
    //                zero++;
    //            } else if (zero == 2)
    //            {
    //                max = Math.Max(max, n);

    //                n = 0;
    //                zero = 1;
    //            } else
    //            {
    //                zero++;
    //            }
    //        }
    //        i++;
    //    }

    //    if (n > max) max = n;
    //    if (!nums.Contains(0)) max = n - 1;

    //    return max;
    //}

    public static int LongestSubarray(int[] nums)
    {
        int max = 0;
        int n = 0;

        int i = 0;
        while (i < nums.Length)
        {
            if (nums[i] == 1)
            {
                n++;
            }
            else
            {
                int a = i + 1;
                while (a < nums.Length)
                {
                    if (nums[a] == 0) break;
                    n += 1;
                    a++;
                }
                max = Math.Max(n, max);

                n = 0;
            }
            i++;
        }

        if (n > max) max = n - 1;

        return max;
    }

    //public static void Main()
    //{
    //    int[] nums = new int[]
    //    {
    //        1,1,0,0,1,1,1,0,1
    //    };

    //    int value = LongestSubarray(nums);
    //    Console.WriteLine(value);
    //}
}
