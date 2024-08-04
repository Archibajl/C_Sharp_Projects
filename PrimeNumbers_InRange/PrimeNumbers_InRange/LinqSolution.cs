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
            //summs up all prime numbers between 2 and 20,000
            //creates a list of numbers between 2 and 20,000
            IEnumerable<int> numbers = Enumerable.Range(2, 20000);

            int prime;
            string output;

            //checks if each number is a prime number
            var primeSums =
             from num in numbers
             where Selection(num) == true         
            select num;
            
            //sums up the output 
            prime = primeSums.Sum();

            output = Convert.ToString(prime);

            return output;
        }
        bool Selection(int Num)
        {
            //creates a list of each number between 2 and one less than the current itteration.
            IEnumerable<int> sumation = Enumerable.Range(2, Num-1);

            bool selector = true;

            //returns the number of numbers that each itteration is true for.
           var truth =
                from prime in sumation
                where Num % prime != 0
                select 1;

            //checks if the same number are not evenly divisible by any other number.
            selector = (truth.Sum() == Num-2);            
            
            return selector;
        }

    }
}
