using System;
using System.Collections.Generic;

namespace Komplex
{
    class Program
    {
        static void Main(string[] args)
        {
            string temp = Console.ReadLine();
            int n = Convert.ToInt32(temp.Split()[0]);
            int m = Convert.ToInt32(temp.Split()[1]);
            int db;
            int max;
            int[,] data = new int[n, m];
            List<int> dailymax = new List<int>();
            int[] maxamount = new int[n];

            for (int i = 0; i < n; i++)
            {
                string temp2 = Console.ReadLine();
                for (int j = 0; j < m; j++)
                {
                    data[i, j] = Convert.ToInt32(temp2.Split()[j]);
                }
            }

            
            for (int j = 0; j < m; j++)
            {
                max = -51;
                for (int i = 0; i < n; i++)
                {
                    if (data[i,j] > max)
                    {
                        max = data[i, j];
                    }
                }
                dailymax.Add(max);
            }

            
            for (int i = 0; i < n; i++)
            {
                db = 0;
                for (int j = 0; j < m; j++)
                {
                    if (data[i,j] == dailymax[j])
                    {
                        db += 1;
                    }

                }
                maxamount[i] = db;
            }
            for (int x = m; x >= 0; x--)
            {
                for (int i = 0; i < n; i++)
                {
                    if (maxamount[i] == x)
                    {
                        Console.Write($"{i+1} ");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
