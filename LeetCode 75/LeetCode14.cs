using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode14;

public class Solution
{
    public static double FindMaxAverage(int[] nums, int k)
    {
        int sum = 0;

        for (int i = 0; i < k; i++)
            sum += nums[i];

        int max = sum;

        for (int i = k; i < nums.Length; i++)
        {
            sum = sum - nums[i - k] + nums[i];
            max = Math.Max(max, sum);
        }

        return (double)max / k;
    }

    //public static void Main()
    //{
    //    int[] nums = new int[] {
    //        5
    //    };

    //    int k = 1;

    //    double value = FindMaxAverage(nums, k);
    //    Console.WriteLine(value);
    //}
}
