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
                var AStudents =
                from student in students
                where student.HistoryGrade >= 90
                where student.MathGrade >= 90
                where student.ScienceGrade >= 90
                select student;

                a_students.AddRange(AStudents);

                foreach (var astudent in a_students)
                {
                    Console.WriteLine("Student ID" + astudent.StudentID + "Is an A student.");
                }

            }
        }


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
                select true
            }
            where TruthVal(g => g == true)
            select wordA;

            return result;
        }

        /// <summary>
        /// HW 3. Finds all jpgs in the given path
        /// 
        /// You will need to change your path in multiple locations to test this.
        /// 1. In Main of this file.
        /// 2. In GetAllPNG_Test in LINQProblems_Test_Cases.cs
        /// 
        /// PLEASE CHANGE BOTH BACK TO @"C:\Users\Ryan\Pictures\" WHEN YOU FINALIZE AND SUMBIT!!!!
        /// </summary>
        public static List<FileInfo> GetAllPNG(string path)
        {
            /* Hints for this problem:
             * new DirectoryInfo(path).EnumerateDirectories("*", SearchOption.AllDirectories);
             * directory.EnumerateFiles("*.png")
             * 
             * However, the enumerated method above might throw exceptions on files that cannot be accessed.
             * To solve this, just test on a path that you know is safe.
             */

            List<FileInfo> files = new List<FileInfo>();

            // from DirectoryInfo directory in new DirectoryInfo(path).GetDirectories()
            //    select new
            //    {
            //        files.AddRange(GetAllPNG(directory.FullName));

            //}
            //foreach (DirectoryInfo directory in new DirectoryInfo(path).GetDirectories())
            //{
            //    files.AddRange(GetAllPNG(directory.FullName));
            //}

            var NewFiles =
            from DirectoryInfo file in new DirectoryInfo(path).GetDirectories()
            where file.Extension == ".png"
            select new {
               select  files.Add(file.ToList)
            };

            //files.AddRange(NewFiles.ToList<FileInfo>());
            return files;

        }
        //Gets the fibonacci numbers for a list of integers.
        public static List<int> GetFibonacciNumbers()
        {
            //Fills the list.
            List<int> Input = new List<int>();
            for (int i = 1; i < 40; i += 5)
                input.Add(i);
            //outputvalue
            List<int> results = new List<int>();

            from number in Input
            where (number == 1) || (number == 2)
            select 

        }


    }
}
