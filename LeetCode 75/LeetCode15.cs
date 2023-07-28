using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode15;
public class Solution
{
    public static int MaxVowels(string s, int k)
    {
        char[] vowels = new char[] { 'a', 'e', 'i','o','u' };

        int[] mas = new int[s.Length];

        for (int i = 0; i < s.Length; i++)
        {
            if (vowels.Contains(s[i]))
            {
                mas[i] = 1;
            }
        }

        int max = 0;

        for (int i = 0; i < k; i++)
        {
            max += mas[i];
        }

        int maxVowels = max;

        for (int i = k; i < mas.Length; i++)
        {
            max = max - mas[i - k] + mas[i];
            if (max > maxVowels)
            {
                maxVowels = max;
            }
        }

        return maxVowels;
    }

    //public static void Main()
    //{
    //    string s = "leetcode";
    //    int k = 3;

    //    int value = MaxVowels(s, k);
    //    Console.WriteLine(value);
    //}
}
