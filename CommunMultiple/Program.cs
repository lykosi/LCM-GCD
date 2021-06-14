using System;
using System.Linq;
using static Common.LCM;
using static Common.GCD;

namespace Common
{
    class Program
    {
        static void Main(string[] args)
        {
            int searchLimit = 100;
            int[] intergers = new int[] { 2, 4 };
            int[] arr = new int[] { 16, 32, 96 };
            int leastCommonMultiple = LeastCommonMultiple(searchLimit, intergers);
            int greatestCommonDivisor = GreatestCommonDivisorMultiple(arr, arr.Length);
            Console.WriteLine($"LeastCommonMultiple: {leastCommonMultiple}");
            Console.WriteLine($"GreatestCommonDivisorMultiple: {greatestCommonDivisor}");
        }
    }
}
