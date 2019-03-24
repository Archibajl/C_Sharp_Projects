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
        //Returns students that have straight A's.
        public void GetStraightAStudents()
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

            List<Student> a_students = new List<Student>();

            {
                //finds all students who's grades are aboce 90 in each catigory.
                var AStudents =
                from student in students
                where student.HistoryGrade >= 90
                where student.MathGrade >= 90
                where student.ScienceGrade >= 90
                select student;

                a_students.AddRange(AStudents);

                //function to print all straight A students.
                foreach (var astudent in a_students)
                {
                    Console.WriteLine("Student ID" + astudent.StudentID + "Is an A student.");
                }

            }
        }


        //Returns any string in a that isn't also in b.
        public List<string> FindStringsInAThatArentInB()
        {
            List<string> a = new List<string>() { "r", "y", "a", "n" };
            List<string> b = new List<string>() { "d", "a", "r", "r", "a", "s" };
            List<string> result = new List<string>();

            //Queries characters in list a that aren't equal to one in list b
            var result1 =
            from wordA in a
            where b.All(g => (wordA != g))
            select wordA;

            //returns the strings in a list.
            result = result1.ToList<string>();

            return result;
        }

        //public static Dictionary<string, List<PhoneBookEntry>> QueryPhoneBookEntries()
        //{
        //    List<PhoneBookEntry> phoneBook = new List<PhoneBookEntry>()
        //    {
        //        new PhoneBookEntry("Sarah", "Jones", "1887 Flat Iron Court", "Colorado Springs", "CO", "80921", "(719) 354-1857"),
        //        new PhoneBookEntry("Josh", "Jones", "1887 Flat Iron Court", "Colorado Springs", "CO", "80921", "(719) 354-1855"),
        //        new PhoneBookEntry("Bryan", "Adams", "1665 Snowflake Lane", "Boston", "MA", "02101", "(617) 143-1566"),
        //        new PhoneBookEntry("John", "Smith", "4745 Meadowland Blvd", "San Diego", "CA", "22434", "(619) 354-6543"),
        //        new PhoneBookEntry("Josh", "Jackson", "1145 Piros Drive", "Orlando", "FL", "32789", "(407) 650-8333"),
        //        new PhoneBookEntry("Hannah", "Maben", "1710 Main Street", "Boston", "MA", "02101", "(617) 765-1857"),
        //        new PhoneBookEntry("Harrison", "James", "1010 Maple Lane", "Denver", "CO", "80014", "(720) 123-4567"),
        //        new PhoneBookEntry("Xavier", "Carlyle", "1552 Washington Avenue", "San Diego", "CA", "22434", "(619) 987-5465"),
        //        new PhoneBookEntry("Michael", "Jones", "6510 Cherry Creek Lane", "Springfield", "TX", "75853", "(361) 234-985"),
        //        new PhoneBookEntry("Sarah", "Smith", "1223 Mirage Drive", "Springfield", "TX", "75853", "(361) 127-5643"),
        //    };

        //    Dictionary<string, List<PhoneBookEntry>> results = new Dictionary<string, List<PhoneBookEntry>>();

        //    results = new Dictionary<string, PhoneBookEntry>(
        //        from entry in phoneBook
        //        where phoneBook[entry].Name == "Josh Jackson"
        //        where phoneBook[entry].LastName == "Jones"
        //        where phoneBook[entry].City == "Colorado Springs"
        //        where phoneBook[entry].PhoneNumber.Substring(0, 3) == "617"
        //        select new
        //        {
        //            phoneBook[entry].FirstName,
        //            phoneBook[entry].LastName,
        //            phoneBook[entry].Address,
        //            phoneBook[entry].City,
        //            phoneBook[entry].State,
        //            phoneBook[entry].ZipCode,
        //            phoneBook[entry].PhoneNumber
        //        }).ToList<PhoneBookEntry>();

        //    //results = Output.ToList<PhoneBookEntry>();
        //    return results;
        //}

        public List<FileInfo> GetAllPNG(string path)
        {
            try
            {
                //outputs all files in the current filepath to a list
                List<FileInfo> tempFiles = new DirectoryInfo(path).GetFiles("*", SearchOption.AllDirectories).OrderBy(t => t.Name).ToList<FileInfo>();

                //searches for files with a png extention.
                var output =
           from FileInfo file in tempFiles
           where file.FullName.EndsWith("png")
           select file;
                //outpouts all files found into a list.
                List<FileInfo> Files = output.ToList<FileInfo>();
                return Files;
            }
            catch (Exception e)
            {
                Console.WriteLine("File inaccessable");
                return null;
            }
            
        }

        //Gets the fibonacci numbers for a list of integers.
        public List<int> GetFibonacciNumbers()
        {
            //Fills the list.
            List<int> Input = new List<int>();
            Input.AddRange(Enumerable.Range(1, 46));
            //Puts all fibinocci numbers from 1 to > 46 into a list.
            int[] Fibonacci = { 1, 2, 3, 5, 8, 13, 21, 34, 55 };
            
            List<int> results = new List<int>();

            //Checks any number in th range 1-46 against all fibbonacci numbers.
            var retVal =
             from int number in Input
             where Fibonacci.Any(a => a == number)
             select number;

            //Converts the found fibbanacci numbers into a list for output.
            results = retVal.ToList<int>();

            return results;
        }
    }
}
