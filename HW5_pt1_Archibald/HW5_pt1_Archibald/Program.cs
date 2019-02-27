using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5_pt1_Archibald
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassicSolution Csln = new ClassicSolution();
            LinqSolution Lsln = new LinqSolution();
            Console.WriteLine($" The sum of all primes solved with Linq,\n" +
                $" between 0 and 2,000,000 is: \n {Lsln.SumPrimes()}");
            Console.WriteLine($" The sum of all primes solved with Linq,\n" +
                $" between 0 and 2,000,000 is: \n {Csln.SumPrimes()}");
        }
    }
}
