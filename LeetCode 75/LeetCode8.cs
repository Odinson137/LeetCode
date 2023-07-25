using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LeetCode8;

public class Solution
{
    static int min = 0;
    static int secondMin = 0;
    public static bool IsMatch(int item)
    {
        return (item == min); 
    }

    public static bool IsMatch2(int item)
    {
        return (item == secondMin);
    }

    public static bool IncreasingTriplet(int[] nums)
    {
        List<int> result = new List<int>(nums);

        while (result.Count() >= 2)
        {
            min = result.Min();
            int indexMin = result.IndexOf(min);

            int num = 1;

            if (result.Count() - indexMin > 1)
            {
                List<int> secondResult = result.GetRange(indexMin+1, result.Count() - indexMin - 1);
                secondMin = secondResult.Min();

                if (secondMin == min)
                {
                    secondResult.RemoveAll(new Predicate<int>(IsMatch));
                    if (secondResult.Count() == 0) return false;
                    secondMin = secondResult.Min();
                    
                }
                int indexSecond = secondResult.IndexOf(secondMin);
                num++;

                if (secondResult.Count() - indexSecond > 1)
                {
                    List<int> thirdResult = secondResult.GetRange(indexSecond + 1, secondResult.Count() - indexSecond - 1);

                    thirdResult.RemoveAll(new Predicate<int>(IsMatch2));
                    if (secondResult.Count() == 0) return false;
                    secondMin = secondResult.Min();

                    if (thirdResult.Count() > 0) return true;
                }
            }

            result.RemoveAll(new Predicate<int>(IsMatch));
        }
        return false;
    }

    //public static bool IncreasingTriplet(int[] nums)
    //{
    //    int i = 0;
    //    int i2 = 1;
    //    int last = 0;
    //    int num = 1;
    //    while (true)
    //    {
    //        if (nums[i2] > nums[last])
    //        {
    //            num++;
    //            last = i2;
    //        }

    //        if (nums[i2] < nums[last])
    //        {
    //            if (num != 2)
    //            {
    //                last = i2;
    //            }
    //        }

    //        if (num == 3)
    //        {
    //            return true;
    //        }

    //        if (nums.Length-1 <= i2)
    //        {
    //            i++;
    //            i2 = i;
    //            num = 1;
    //            last = i;

    //            if (nums.Length - 1 <= i)
    //            {
    //                return false;
    //            }
    //        }


    //        i2++;
    //    }
    //}

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

    //public static void Main()
    //{
    //    int[] nums = new int[] {
    //        1,2,2,1
    //    };
    //    bool value = IncreasingTriplet(nums);
    //    Console.WriteLine(value);
    //}
}
