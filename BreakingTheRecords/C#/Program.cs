using System;

namespace Algorithms_Implementation_BreakingTheRecords_CS
{
    class Program
    {
        static int[] getRecord(int[] s)
        {
            var outPut = new int[2]{0,0};
            int max = s[0];
            int min = s[0];
            foreach(var element in s)
            {
                if(element > max){
                    outPut[0]++;
                    max = element;
                }
                if(element < min){
                    outPut[1]++;
                    min = element;
                }
            }
            return outPut;
        }

        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] s_temp = Console.ReadLine().Split(' ');
            int[] s = Array.ConvertAll(s_temp, Int32.Parse);
            int[] result = getRecord(s);
            Console.WriteLine(String.Join(" ", result));
        }
    }
}
