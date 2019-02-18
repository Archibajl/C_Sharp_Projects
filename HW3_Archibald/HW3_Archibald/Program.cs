using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Console;


namespace HW3_Archibald
{
    class Program
    {
        static void Main(string[] args)
        {
            string directory = @"C://";
            WriteLine("To search and copy enter a directory to search.");
            directory += ReadLine();
        }

        string ReturnFilePath(string start, string fileType)
        {
            string output = null;

            foreach (string directory in Directory.GetDirectories(start))
            {
                foreach( string files in Directory.GetFiles(directory, fileType))
                {
                    output = files;
                }
            }

            return output;
        }
    }
}
