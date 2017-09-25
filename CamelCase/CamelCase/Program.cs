using System;
using System.Linq;
namespace CamelCase
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            int count = 0;
            if (!string.IsNullOrWhiteSpace(s))
            {
                count = 1;
                for (char i = 'A'; i <= 'Z'; i++)
                {
                    count += s.Count(x => x == i);
                }
            }
            System.Console.WriteLine(count);
        }
    }
}
