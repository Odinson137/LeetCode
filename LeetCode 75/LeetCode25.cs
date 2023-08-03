using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode25;

public class Solution
{
    public static int[] AsteroidCollision(int[] asteroids)
    {
        Stack<int> stack = new Stack<int>();

        foreach (int asteroid in asteroids)
        {
            if (asteroid > 0)
                stack.Push(asteroid);
            else
            {
                while (stack.Count > 0 && stack.Peek() > 0 && stack.Peek() < Math.Abs(asteroid))
                    stack.Pop();
                if (stack.Count == 0 || stack.Peek() < 0)
                    stack.Push(asteroid);
                else if (stack.Peek() == Math.Abs(asteroid))
                    stack.Pop();
            }
        }

        int[] ints = stack.ToArray();
        Array.Reverse(ints);
        return ints;
    }

    //public static void Main()
    //{
    //    int[] asteroids = new int[]
    //    {
    //        5,10,-5
    //    };

    //    var value = AsteroidCollision(asteroids);
    //    for (int i = 0; i < value.Length; i++)
    //        Console.WriteLine(value[i]);
    //}
}
