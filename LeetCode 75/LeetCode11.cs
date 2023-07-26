using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode11;

public class Solution
{
    public static bool IsSubsequence(string s, string t)
    {
        int i = 0;
        int a = 0;
        while (i < t.Length && a < s.Length)
        {
            if (t[i] == s[a])
            {
                a++;
            }
            i++;
        }

        return a == s.Length;
    }

    //public static void Main()
    //{
    //    string s = "";
    //    string t = "ahxgdc";

    //    bool value = IsSubsequence(s, t);
    //    Console.WriteLine(value);
    //}

}
