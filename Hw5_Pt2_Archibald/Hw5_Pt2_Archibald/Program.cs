using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw5_Pt2_Archibald
{
    class Program
    {        
        static void Main(string[] args)
        {
            //Note i had to remove most of the static declerations in order to get them to print.

            Program p = new Program();
            SolutionsLinq Sql = new SolutionsLinq();
            List<Student> stt = new List<Student>();
                        
            Console.WriteLine($" Get all straight a students in a list.");
            Sql.GetStraightAStudents();
            Console.WriteLine($" The item which is most profitable: {DetermineWhichItemWasMostProfitable().ItemName}");
            Console.WriteLine($"The sum of all prime numbers between 2 and 1000 is {p.SumPrimes()}");
            Console.WriteLine($"Finds strings in list a that aren't in list b");
            foreach (string a in Sql.FindStringsInAThatArentInB()) {
                Console.Write("{0}, ",a);
            }
            foreach(System.IO.FileInfo file in Sql.GetAllPNG(@"C:\Users\Ryan\Pictures\"))
            {
                Console.WriteLine(file);
            }
            Console.WriteLine("All fibonacci numbers between 1 and 46");
            foreach (int c in Sql.GetFibonacciNumbers())
            {
                Console.Write("{0}, ", c);
            }

            Console.ReadKey();
        }

        

        //Returns which item is most profitable.
        public static Item DetermineWhichItemWasMostProfitable()
        {
            //list to store initial values.
            List<Item> items = new List<Item>()
            {
                new Item("TV", 5, 515.15f),
                new Item("DVD Player", 10, 100.05f),
                new Item("Toy Horse", 2, 25.25f),
                new Item("Shovel", 1, 10.99f),
                new Item("Kite", 4, 5.77f),
                new Item("Stapler", 15, 5.98f),
                new Item("Pen", 25, 2.25f),
                new Item("Candy Bar", 102, 1.5f),
                new Item("DVD", 45, 20),
                new Item("Soda", 66, 1.5f),
            };

            List<Item> highestEarner = new List<Item>();
            
            //uses a lambda expression to check values against all other values in the list.
            var ItemMostProf =                                        
                from item in items
                where true == items.All(x =>  ( x.ItemPrice * x.NumberOfSales ) <= ( item.ItemPrice * item.NumberOfSales ) )
                select item;
            //uses a list to output values.
            highestEarner = ItemMostProf.ToList<Item>();
            Item HighestEarner = new Item("Temp", 0, 0);

            HighestEarner = highestEarner[0];
            
                return HighestEarner;
        }

        // Finds and sums the values of all primes between 2 and 1,000.
        public int SumPrimes()
        {
            IEnumerable<int> Numbers = Enumerable.Range(2, 1000);

            //Checks if each number is a prime number.
            //Tried nesting a linq and setting a variable to number % of all numbers up to number != 0 and a lambda that should do the same thing.
            //Neither returned any results, so i went back to using an outside function with a linq.
            var PrimeNumbers =
            from number in Numbers
            where Prime(number) == true
            select number;           

            //Returns the sums of the output.
            int primeSums = PrimeNumbers.Sum();
            return primeSums;
        }
        bool Prime(int Num)
        {
            //resizes the range of numbers up to the number being checked
            IEnumerable<int> Numbers2 = Enumerable.Range(2, Num);
            bool selector = true;


            //returns the number of numbers that each itteration is true for.
            var truth =
                 from prime in Numbers2
                 where Num % prime != 0
                 select 1;

            //checks if the same number are not evenly divisible by any other number.
            selector = (truth.Sum() == Num - 1);

            return selector;
        }
    }
}

