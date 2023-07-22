using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode3;

class LeetCode3
{
    private static IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        //IList<bool> ret = new List<bool>(candies.Length);
        int max = candies.Max();
        //for (int i = 0; i < candies.Length; i++)
        //{
        //    if (candies[i] + extraCandies >= max)
        //    {
        //        ret.Add(true);
        //    }
        //    else ret.Add(false);
        //}

        return candies.Select(x=> (x+extraCandies) >= max).ToList();
    }

    public void Main()
    {
        int[] candies = new int[] { 2, 3, 5, 1, 3 };
        int extraCandies = 3;
        IList<bool> ret = KidsWithCandies(candies, extraCandies);
        foreach (bool i in  ret)
        {
            Console.Write(i + " ");
        }
    }
}
