using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LeetCode26;

public class Solution
{

    static (string letters, int number) ExtractLettersAndNumber(string input)
    {
        // Находим индекс первой цифры в строке.
        int numberStartIndex = 0;
        while (numberStartIndex < input.Length && !char.IsDigit(input[numberStartIndex]))
        {
            numberStartIndex++;
        }

        // Извлекаем подстроку до первой цифры - это будут буквы.
        string letters = input.Substring(0, numberStartIndex);

        // Извлекаем подстроку, начиная с первой цифры - это будут цифры.
        string numberString = input.Substring(numberStartIndex);

        // Преобразуем подстроку цифр в число.
        int number = int.Parse(numberString);

        return (letters, number);
    }

    static string ExpoStr(string str, int expo)
    {
        string newStr = "";
        for (int i = 0; i < expo; i++)
            newStr += str;
        return newStr;
    }

    public static string DecodeString(string s)
    {
        int i = 0;
        Stack<string> stack = new Stack<string>();
        string str = "";

        while (i < s.Length)
        {
            if (s[i] == '[')
            {
                stack.Push(str);
                str = "";

            } else if (s[i] == ']') 
            {
                string temp = stack.Pop();
                (string letters1, int num1) = ExtractLettersAndNumber(temp);
                string readyString = letters1 + ExpoStr(str, num1);

                str = readyString;
            }
            else
                str += s[i];
            i++;
        }

        return str;
    }

    //public static void Main()
    //{
    //    string s = "2[abc]3[cd]ef";

    //    var value = DecodeString(s);
    //    Console.WriteLine(value);
    //}

}