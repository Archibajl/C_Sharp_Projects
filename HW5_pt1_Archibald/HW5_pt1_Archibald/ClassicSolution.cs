using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5_pt1_Archibald
{
    class ClassicSolution
    {
        public string SumPrimes()
        {
            
            int primeSum = 0;
            for(int i=0; i <2000000; i++)
            {
                bool isPrime = true;
                for (int c = 2; c<i; c++)
                {
                    if (i%c == 0)
                    {
                        isPrime = false;
                    }
                }
                if(isPrime == true)
                {
                    primeSum += i;
                    Console.WriteLine($"{i} is Prime.");
                }
            }
            return Convert.ToString(primeSum);
        }
    }
}
