using System.Security.Principal;

namespace LeetCode19;

public class Solution
{
    public static int PivotIndex(int[] nums)
    {
        List<int> mas = new List<int>(nums);

        for (int i = 1, last = nums.Length - 2; i < nums.Length; i++, last--)
        {
            nums[i] += nums[i - 1];
            mas[last] += mas[last + 1];
        }

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == mas[i])
            {
                return i;
            }
        }
        return -1;
    }
    //public static void Main()
    //{
    //    int[] gain = new int[]
    //    {
    //        2,1,-1
    //    };

    //    int value = PivotIndex(gain);
    //    Console.WriteLine(value);
    //}

}
