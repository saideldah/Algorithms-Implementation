using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MigratoryBirds
{
    class Program
    {
        static int migratoryBirds(int n, int[] ar)
        {
            int mostComon = 1;
            int mostComonNumber = 0;
            int current = 0;
            for (int t = 1; t <= 5; t++)
            {
                current = 0;
                for (int i = 0; i < n; i++)
                {
                    if (ar[i] == t)
                    {
                        current++;
                    }
                }
                if (current>mostComonNumber)
                {
                    mostComon = t;                
                    mostComonNumber = current;
                }
            }
            return mostComon;
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
        string[] ar_temp = Console.ReadLine().Split(' ');
        int[] ar = Array.ConvertAll(ar_temp,Int32.Parse);
        int result = migratoryBirds(n, ar);
        Console.WriteLine(result);
        }
    }
}
