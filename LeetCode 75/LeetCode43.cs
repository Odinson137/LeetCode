using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class LeetCode43
{
    public int FindCircleNum(int[][] isConnected)
    {
        bool[] bools = new bool[isConnected.Length];
        int province = 0;
        for (int i = 0; i < isConnected.Length; i++)
        {
            if (bools[i] == false)
            {
                province++;
                DFS(isConnected, bools, i);
            }
        }
        return province;
    }

    private void DFS(int[][] isConnected, bool[] bools, int indexCity)
    {
        bools[indexCity] = true;

        for (int i = 0; i < isConnected.Length; i++)
        {
            if (isConnected[indexCity][i] == 1 && bools[i] == false)
            {
                DFS(isConnected, bools, i);
            }
        }
    }
}

