using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Hw5_Pt2_Archibald
{
    class SolutionsLinq
    {
        
        //Returns any string in a that isn't also in b.
        public static List<string> FindStringsInAThatArentInB()
        {
            List<string> a = new List<string>() { "r", "y", "a", "n" };
            List<string> b = new List<string>() { "d", "a", "r", "r", "a", "s" };
            List<string> result = new List<string>();

            result =
            from wordA in a
            let TruthVal = new
            {
                retval =
                from wordB in b
                where wordA != wordB
                select 1
            }
            where TruthVal.All(g => g >= 1)
            select wordA;

            return result;
        }

        //Returns students that have straight A's.
        public static List<Student> GetStraightAStudents()
        {
            List<Student> students = new List<Student>()
            {
                new Student(1, 87, 89, 91, 92),
                new Student(2, 90, 92, 93, 99),
                new Student(3, 87, 91, 97, 100),
                new Student(4, 86, 88, 93, 100),
                new Student(5, 86, 89, 94, 98),
                new Student(6, 93, 94, 99, 100),
                new Student(7, 87, 89, 95, 99),
                new Student(8, 91, 94, 95, 97),
                new Student(9, 85, 94, 99, 100),
                new Student(10, 85, 92, 93, 95),
            };

            {
                var AStudents =
                from student in students
                where student.HistoryGrade >= 90
                where student.MathGrade >= 90
                where student.ScienceGrade >= 90
                select student;

                return AStudents.ToList<Student>();
            }           
        }

        //Returns which item is most profitable.
        public static Item DetermineWhichItemWasMostProfitable()
        {
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

            var ItemMostProf = 
            from item in items
            where items.All(x => x.NumberOfSales * x.ItemPrice > item.NumberOfSales * item.ItemPrice )
            select item; 

            return ItemMostProf.ToArray<Item>();
        }

        //Gets the fibonacci numbers for a list of integers.
        public static List<int> GetFibonacciNumbers()
        {
            List<int> input = new List<int>();

        }

            // Finds and sums the values of all primes between 2 and 1,000.
            public static int SumPrimes()
            {
                IEnumerable<int> Numbers = Enumerable.Range(2, 1000);
                IEnumerable<int> Numbers2 = Enumerable.Range(2, 1000);


            var PrimeNumbers =
            from number in Numbers
            let Output = new
             {
                 Out =
                from num in Numbers2 where num <= number
                where number % num != 0
                select 1
            }
            where Convert.ToInt32(Output) == number
            select number;

            return PrimeNumbers.Sum();
            }

        }



       
}
