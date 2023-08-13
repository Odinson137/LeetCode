using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace LeetCode46;



public class Solution
{
    public static int NearestExit(char[][] maze, int[] entrance)
    {
        int rows = maze.Length;
        int cols = maze[0].Length;

        Dictionary<Tuple<int, int>, List<Tuple<int, int>>> adjacencyList = new Dictionary<Tuple<int, int>, List<Tuple<int, int>>>();

        int[] dr = { -1, 1, 0, 0 };
        int[] dc = { 0, 0, -1, 1 };

        // Создаем список смежности
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                if (maze[row][col] == '.')
                {
                    var currentCell = Tuple.Create(row, col);
                    var neighbors = new List<Tuple<int, int>>();

                    for (int j = 0; j < 4; j++)
                    {
                        int newRow = row + dr[j];
                        int newCol = col + dc[j];

                        if (newRow >= 0 && newRow < rows && newCol >= 0 && newCol < cols && maze[newRow][newCol] == '.')
                        {
                            neighbors.Add(Tuple.Create(newRow, newCol));
                        }
                    }

                    adjacencyList[currentCell] = neighbors;
                }
            }
        }

        // Инициализируем BFS
        Queue<Tuple<int, int>> queue = new Queue<Tuple<int, int>>();
        var el = Tuple.Create(entrance[0], entrance[1]);
        queue.Enqueue(el);

        HashSet<Tuple<int, int>> visited = new HashSet<Tuple<int, int>> { el };

        int n = 0;
        while (queue.Count > 0)
        {
            int count = queue.Count;

            for (int i = 0; i < count; i++)
            {
                Tuple<int, int> tuple = queue.Dequeue();

                foreach (Tuple<int, int> t in adjacencyList[tuple])
                {
                    if (t.Item1 == 0 || t.Item1 == rows - 1 || t.Item2 == 0 || t.Item2 == cols - 1)
                    {
                        if (t.Item1 != entrance[0] || t.Item2 != entrance[1])
                        {
                            return n + 1; // Добавляем 1, чтобы учесть текущий ход
                        }
                    }

                    if (!visited.Contains(t))
                    {
                        queue.Enqueue(t);
                        visited.Add(t);
                    }
                }
            }
            n++;
        }

        return -1; // Выход не найден
    }

    public static void Main()
    {
        char[][] maze = new char[][] {
            new char[] { '+', '.', '+', '+', '+', '+', '+' },
            new char[] { '+', '.', '+', '.', '.', '.', '+' },
            new char[] { '+', '.', '+', '.', '+', '.', '+' },
            new char[] { '+', '.', '.', '.', '+', '.', '+' },
            new char[] { '+', '+', '+', '+', '+', '.', '+' }
        };


        //char[][] maze = new char[][] {
        //    new char[] { '+', '+', '+' },
        //    new char[] { '.', '.', '.' },
        //    new char[] { '+', '+', '+' }
        //};


        int[] entrance = new int[]
        {
            0, 1
        };

        int value = NearestExit(maze, entrance);
        Console.WriteLine(value);
    }
}