using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static public IList<string> FizzBuzz(int n)
        {
            List<string> strList = new List<string>();
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    strList.Add("FizzBuzz");
                }
                else if (i%3 == 0)
                {
                    strList.Add("Fizz");
                }
                else if (i%5 == 0)
                {
                    strList.Add("Buzz");
                }
                else
                {
                    
                    strList.Add(i.ToString());
                }
            }
            return strList;
        }
        static void Main(string[] args)
        {
            IList<string> strList = FizzBuzz(15);

            foreach (var str in strList)
            {
                Console.WriteLine(str);
            }
        }
    }
}
