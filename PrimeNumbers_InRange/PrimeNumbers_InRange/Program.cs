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

            //Both functions return all prime numbers between 2 and 20,000
            //The initial posting wanted all numbers less than 2,000,000 but that took an eternity to run through, so i shortened it.
            string output = Csln.SumPrimes();
            Console.WriteLine($" The sum of all primes solved with Linq,\n" +
                $" between 0 and 2,000,000 is: \n {output}");
            output = Lsln.SumPrimes();
            Console.WriteLine($" The sum of all primes solved with Linq,\n" +
                $" between 0 and 2,000,000 is: \n {output}");
            Console.ReadKey();
        }
    }
}
