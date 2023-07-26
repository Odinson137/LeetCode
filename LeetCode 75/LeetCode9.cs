using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode9;

public class Solution
{
    public static int Compress(char[] chars)
    {
        List<char> forChars = new List<char>();
        List<int> forNum = new List<int>();

        //Dictionary<char, int> dictChars = new Dictionary<char, int>();
        char last = ' ';
        int i = -1;
        foreach (char c in chars)
        {
            if (c == last)
            {
                forNum[i]++;
            } else
            {
                forChars.Add(c);
                forNum.Add(1);
                i++;
                last = c;
            }
        }

        StringBuilder str = new StringBuilder();

        for (i = 0; i < forChars.Count(); i++)
        {
            str.Append(forChars[i]);
            if (forNum[i] != 1)
                str.Append(forNum[i]);
        }

        string s = str.ToString();
        for (i = 0; i < str.Length; i++)
        {
            chars[i] = s[i];
        }

        return str.Length;
    }

    //public static void Main()
    //{
    //    char[] chars = new char[] {
    //    'a','a','b','b','c','c','c', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a', 'a'
    //};
    //    int value = Compress(chars);
    //    Console.WriteLine(value);
    //}
}
