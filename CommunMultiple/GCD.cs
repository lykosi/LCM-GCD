using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    class GCD
    {
        public static int GreatestCommonDivisor(int a, int b)
        {
            if (a == 0)
                return b;
            return GreatestCommonDivisor(b % a, a);
        }

        public static int GreatestCommonDivisorMultiple(int[] arr, int arrLimit)
        {
            int result = arr[0];
            for (int i = 1; i < arrLimit; i++)
                result = GreatestCommonDivisor(arr[i], result);
            if (result == 1)
                return 1;
            return result;
        }
    }
}
