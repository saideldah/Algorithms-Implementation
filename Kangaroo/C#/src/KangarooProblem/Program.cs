using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KangarooProblem
{
    public class Program
    {
        static string kangaroo(int x1, int v1, int x2, int v2)
        {
            // Complete this function
            string result = "";
            if (v1 <= v2)
            {
                result = "no";
                return result;
            }
            int k1CurrentLocation = x1;
            int k2CurrentLocation = x2;
            while (k1CurrentLocation < k2CurrentLocation)
            {
                k1CurrentLocation += v1;
                k2CurrentLocation += v2;
            }
            if (k1CurrentLocation == k2CurrentLocation)
            {
                result = "yes";
            }
            else
            {
                result = "no";
            }

            return result;

        }

        static void Main(String[] args)
        {
            string[] tokens_x1 = Console.ReadLine().Split(' ');
            int x1 = Convert.ToInt32(tokens_x1[0]);
            int v1 = Convert.ToInt32(tokens_x1[1]);
            int x2 = Convert.ToInt32(tokens_x1[2]);
            int v2 = Convert.ToInt32(tokens_x1[3]);
            string result = kangaroo(x1, v1, x2, v2);
            Console.WriteLine(result);
        }
    }
}
