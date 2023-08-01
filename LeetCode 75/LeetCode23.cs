using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode23;

public class Solution
{
    public static int EqualPairs(int[][] grid)
    {
        List<string> rows = new List<string> (grid.Length);

        List<string> columns = new List<string> (grid.Length);

        foreach (var i in grid)
        {
            columns.Add("");
        }

        for (int i = 0; i < grid.Length; i++)
        {
            string oneRow = "";
            for (int j = 0; j < grid[i].Length; j++)
            {
                oneRow += (grid[i][j].ToString() + " ");
                columns[j] += (grid[i][j].ToString() + " ");
            }

            rows.Add(oneRow);
        }

        int s = 0;
        foreach (string sb in rows)
        {
            foreach (string sb1 in columns)
            {
                if (sb == sb1)
                {
                    s++;
                }
            }
        }

        return s;
    }

    //public static void Main()
    //{
    //    int[][] grid = new int[][] {
    //        new int[] { 13,13 },
    //        new int[] { 13,13 },

    //        //new int[] { 11,1 },
    //        //new int[] { 1,11 },

    //        //new int[] { 3,1,2,2 },
    //        //new int[] { 1,4,4,4},
    //        //new int[] { 2,4,2,2 },
    //        //new int[] { 2,5,2,2 },
    //    };

    //    var value = EqualPairs(grid);
    //    Console.WriteLine(value);
    //}
}
