using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode12;

public class Solution
{
    public static int MaxArea(int[] height)
    {
        int maxArea = 0;

        int i = 0;
        int a = height.Length - 1;

        while (i != a)
        {
            int len = a - i;
            int hei = Math.Min(height[i], height[a]);
            int newArea = hei * len;
            if (newArea > maxArea)
                maxArea = newArea;

            if (height[i] > height[a])
                a--;
            else
                i++;
        }

        return maxArea;
    }

    //public static void Main()
    //{
    //    int[] height = new int[] { 
    //        1, 8, 6, 2, 5, 4, 8, 3, 7 
    //    };

    //    int value = MaxArea(height);
    //    Console.WriteLine(value);
    //}
}
