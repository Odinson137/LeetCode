using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode6;

public class Solution
{
    public static string ReverseWords(string s)
    {
        string[] strMas = s.Split(" ");

        StringBuilder sb = new StringBuilder();

        for (int i = strMas.Length-1; i > 0; i--)
        {
            if (strMas[i] != "")
            {
                sb.Append(strMas[i].Trim());
                sb.Append(' ');
            }
        }

        sb.Append(strMas[0]);
        return sb.ToString().Trim();
    }

    public static void Main()
    {
        string s = "  hello world  ";
        string readyStr = ReverseWords(s);
        Console.Write(readyStr);
    }
}
