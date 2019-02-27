using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5_pt1_Archibald
{
    class LinqSolution
    {
        public string SumPrimes()
        {
            int primeSums = 0;
            List<LinqSolution> Numbers = new List<LinqSolution>();
                Numbers.InsertRange(1, 2000000);
            int prime+= IsPrime(Numbers);
            return Convert.ToString(primeSums);
        }
    }
}
