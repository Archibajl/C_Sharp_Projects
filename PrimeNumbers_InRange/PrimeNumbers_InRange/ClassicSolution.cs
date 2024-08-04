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
            //sums up all numbers between 2 and 20,000 and returns the summation of all prime numbers between them
            int primeSum = 0;
            for(int i=2; i <20000; i++)
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
                }
            }
            string primesum = Convert.ToString(primeSum);
            return primesum;
        }
    }
}
