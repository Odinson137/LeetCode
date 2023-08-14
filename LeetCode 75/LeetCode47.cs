using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode47;

public class Solution
{
    public static Tuple<int, int> SearchStart(int[][] grid)
    {
        Tuple<int, int> start;
        for (int i = 0; i < grid.Length; i++)
        {
            for (int b = 0; b < grid[i].Length; b++)
            {
                if (grid[i][b] == 2)
                {
                    start = new Tuple<int, int>(i, b);
                    return start;
                }
            }
        }
        return new Tuple<int, int>(0, 0);
    }

    public static int OrangesRotting(int[][] grid)
    {
        int rows = grid.Length;
        int cols = grid[0].Length;
        int freshOranges = 0;
        Queue<(int, int, int)> queue = new Queue<(int, int, int)>();
        int[][] directions = new int[][] { new int[] { -1, 0 }, new int[] { 1, 0 }, new int[] { 0, -1 }, new int[] { 0, 1 } };

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (grid[i][j] == 1)
                {
                    freshOranges++;
                }
                else if (grid[i][j] == 2)
                {
                    queue.Enqueue((i, j, 0));
                }
            }
        }

        int minutes = 0;
        while (queue.Count > 0)
        {
            var (row, col, time) = queue.Dequeue();
            minutes = time;

            foreach (var dir in directions)
            {
                int newRow = row + dir[0];
                int newCol = col + dir[1];

                if (newRow >= 0 && newRow < rows && newCol >= 0 && newCol < cols && grid[newRow][newCol] == 1)
                {
                    grid[newRow][newCol] = 2;
                    freshOranges--;
                    queue.Enqueue((newRow, newCol, time + 1));
                }
            }
        }

        if (freshOranges == 0)
        {
            return minutes;
        }
        else
        {
            return -1;
        }
    }

    public static void Main()
    {
        int[][] grid = {
            new int[] { 2, 1, 1 },
            new int[] { 1, 1, 0 },
            new int[] { 0, 1, 1 }
        };

        int value = OrangesRotting(grid);
        Console.WriteLine(value);
    }
}