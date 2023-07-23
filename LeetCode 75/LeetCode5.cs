using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode5;

public class Solution
{
    public static string ReverseVowels(string s)
    {
        char[] str = s.ToCharArray();

        Stack<char> vowels = new Stack<char>();

        for (int i = 0; i < str.Length; i++)
            if ("aeiouAEIOU".Contains(str[i]))
                vowels.Push(str[i]);

        for (int i = 0; i < s.Length; i++)
            if ("aeiouAEIOU".Contains(str[i]))
                str[i] = vowels.Pop();
        return new string(str);
    }

    //public static void Main()
    //{
    //    string s = "hello";
    //    string readyStr = ReverseVowels(s);
    //    Console.Write(readyStr);
    //}
}
