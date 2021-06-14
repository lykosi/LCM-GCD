using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    class LCM
    {
        public static int LeastCommonMultiple(int limit, params int[] intergers)
        {
            int defaultValue = -1;
            var maxInt = intergers.Max();

            for (int multiple = maxInt; multiple < limit; multiple++)
            {
                bool isMultiple = true;
                foreach (var item in intergers)
                {
                    if (multiple % item != 0)
                        isMultiple = false;
                }
                if (isMultiple)
                    return multiple;
            }
            return defaultValue;
        }
    }
}
