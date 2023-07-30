using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode20
{
    public class Solution
    {
        public static IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
        {
            HashSet<int> answer1 = new HashSet<int>(nums1);
            HashSet<int> answer2 = new HashSet<int>(nums2);

            HashSet<int> intersection1 = new HashSet<int>(answer1);
            intersection1.ExceptWith(answer2);

            HashSet<int> intersection2 = new HashSet<int>(answer2);
            intersection2.ExceptWith(answer1);

            IList<IList<int>> mas = new List<IList<int>>() 
            {
                new List<int>(intersection1),
                new List<int>(intersection2)
            };

            return mas;
        }


        //public static void Main()
        //{
        //    int[] nums1 = new int[]
        //    {
        //        1,2,3,3
        //    };

        //    int[] nums2 = new int[]
        //    {
        //        1,1,2,2
        //    };

        //    var value = FindDifference(nums1, nums2);
        //    Console.WriteLine(value);
        //}
    }
}
