using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode13;

public class Solution
{
    public static int MaxOperations(int[] nums, int k)
    {
        Array.Sort(nums);

        int n = 0;

        int i = 0;
        int last = nums.Length - 1;

        while (i < last)
        {
            int sum = nums[i] + nums[last];
            if (sum == k)
            {
                n++;
                i++;
                last--;

                nums[i - 1] = 0;
                nums[last + 1] = 0;
            }

            else if (sum < k)
            {
                i++;
            } 
            else 
            {
                last--;
            }
        }

        return n;

    }

    //public static void Main()
    //{
    //    int[] nums = new int[] {
    //        1,2,3,4
    //    };

    //    int k = 5;

    //    int value = MaxOperations(nums, k);
    //    Console.WriteLine(value);
    //}
}