using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Practice.HackerRank
{
    class ArrayLeftRotation
    {

        // https://www.hackerrank.com/challenges/ctci-array-left-rotation
        public static void Run(String[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);

            // Truncate redundant shifts
            if (k > n)
            {
                k = k % n;
            }

            int[] res = new int[n];
            int ix = 0;
            for (int i = k; i < n; i++)
            {
                res[ix] = a[i];
                ix++;
            }
            for (int z = 0; z < k; z++)
            {
                res[ix + z] = a[z];
            }

            for (int j = 0; j < res.Length; j++)
            {
                Console.Write(res[j]);
                if (j != res.Length - 1)
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.WriteLine();
                }
            }

            Console.ReadLine();

        }
    }

}