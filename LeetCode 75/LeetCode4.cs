using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode4;

class LeetCode4
{
    public static bool CanPlaceFlowers(int[] flowerbed, int n)
    {
        int len = flowerbed.Length;
        if (len < 3)
        {
            if (n > 1) return false;
            if (flowerbed.Contains(1) && n != 0) return false;
            else return true;
        }
        else
        {
            for (int i = 0; i < len; i++)
            {
                if (flowerbed[i] == 1)
                {
                    if (i + 1 != len)
                    {
                        flowerbed[i + 1] = 2;
                    }
                    if (i - 1 != -1)
                    {
                        flowerbed[i - 1] = 2;
                    }
                }
            }
            int sum = 0;
            for (int i = 0; i < len; i++)
            {
                if (flowerbed[i] == 0)
                {
                    sum++;

                    if (i + 1 != len)
                    {
                        flowerbed[i + 1] = 2;
                    }
                    if (i - 1 != -1)
                    {
                        flowerbed[i - 1] = 2;
                    }
                }
            }

            if (sum >= n) return true;
        }

        return false;
    }


    //int len = flowerbed.Length;
    //if (len < 3)
    //{
    //    if (n > 1) return false;
    //    if (flowerbed.Contains(1) && n != 0) return false;
    //    else return true;
    //} else
    //{
    //    int sum = 0;

    //    for (int i = 0; i < len; i++)
    //    {
    //        if (i + 1 != len && i - 1 != -1)
    //        {
    //            if (flowerbed[i + 1] == 0 && flowerbed[i - 1] == 0 && flowerbed[i] == 0)
    //            {
    //                sum++;
    //                flowerbed[i] = 1;
    //            }
    //        } else
    //        {
    //            if (flowerbed[i] == 0 && flowerbed[i+1] == 0) 
    //            {
    //                sum++;
    //                flowerbed[0] = 1;
    //            }
    //            if (flowerbed[len - 1] == 0 && flowerbed[len - 2] == 0)
    //            {
    //                sum++;
    //                flowerbed[0] = 1;
    //            }
    //        }
    //    }

    //    //if (flowerbed[0] == 0 && flowerbed[1] == 0) sum++;
    //    //if (flowerbed[len-1] == 0 && flowerbed[len-2] == 0) sum++;
    //    Console.WriteLine(string.Join("", flowerbed));

    //    if (sum >= n) return true;
    //}

    //return false;

    public static void Main()
    {
        int[] flowerbed = new int[] { 0, 1, 0, 1, 0, 1, 0, 0 };
        int n = 2;
        bool a = CanPlaceFlowers(flowerbed, n);
        Console.Write(a);
    }
}
