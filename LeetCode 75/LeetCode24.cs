using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode24;

public class Solution
{
    public static string RemoveStars(string s)
    {
        Stack<char> st = new Stack<char>();

        for (int i = 0; i < s.Length; i++)
            if (s[i] == '*')
                st.Pop();
            else
                st.Push(s[i]);

        Stack<char> st1 = new Stack<char>();
        foreach (char c in st)
            st1.Push(c);
        return string.Join("", st1);
    }

    //public static void Main()
    //{
    //    string s = "leet**cod*e";

    //    var value = RemoveStars(s);
    //    Console.WriteLine(value);
    //}
}
