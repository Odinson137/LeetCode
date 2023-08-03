using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode28;

public class Solution
{
    public static string PredictPartyVictory(string senate)
    {
        Queue<char> senates = new Queue<char>(senate);

        int n = 0;
        char first = senates.Peek();
        while (senates.Count != n)
        {
            char sen = senates.Dequeue();
            if (sen == first)
            {
                n++;
                senates.Enqueue(sen);
            }
            else
            {
                if (n > 0)
                    n--;
                else
                {
                    first = sen;
                    senates.Enqueue(sen);
                    n = 1;
                }
            }
        }

        if (senates.Peek() == 'R')
            return "Radiant";
        else
            return "Dire";
    }

    //public static void Main()
    //{
    //    string senate = "RDD";

    //    var value = PredictPartyVictory(senate);
    //    Console.WriteLine(value);
    //}
}


