using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode7;

public class Solution
{

    public static int[] ProductExceptSelfSecond(int[] nums)
    {
        int[] newNums = new int[nums.Length];

        int n = 1;
        newNums[0] = n;
        for (int i  = 1; i < nums.Length; i++)
        {
            n *=  nums[i - 1];
            newNums[i] = n;
        }

        n = 1;
        for (int i = nums.Length - 2; i >= 0; i--) 
        {
            n *= nums[i + 1];
            newNums[i] = newNums[i] * n;
        }

        return newNums;
    }

    public static int[] ProductExceptSelf(int[] nums)
    {
        int[] newNums = new int[nums.Length];
        int selectedI = 0;
        int i2 = 0;

        newNums[0] = 1;

        while (true)
        {
            if (selectedI != i2)
            {
                newNums[selectedI] *= nums[i2];
            }

            if (i2 == nums.Length-1)
            {
                selectedI++;

                if (selectedI == nums.Length) break;
                
                newNums[selectedI] = 1;
                i2 = -1;
            }

            i2++;
        }

        return newNums;
    }

    //public static void Main()
    //{
    //    int[] nums = new int[] { 1, 2, 3, 4 };
    //    int[] newNums = ProductExceptSelfSecond(nums);
    //    foreach (int num in newNums) Console.WriteLine(num);
    //}
}
