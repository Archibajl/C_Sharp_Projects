using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;


namespace HW3_Archibald
{
    class CopyFile
    {
        static void Main(string[] args)
        {
            FindFiles f = new FindFiles();
            CopySpecifiedFiles c = new CopySpecifiedFiles();
            string directory = @"";
            string fileType = @"";
            string newLocation = null;
            string[] filesFound = null;
            //Search directory and filetype input.
             WriteLine("To search and copy enter a directory to search.");
             directory = @ReadLine();
             WriteLine("Enter a filetype to copy.");
             fileType = ReadLine();             
            //Returns the locations of all files that match the desired filetype from the specified folders.
             filesFound = f.ReturnFilePath(directory, fileType);
            WriteLine("Files to be copied: \n");
            //Prints the path for each file found to be copied.
            for(int i= 0; i< filesFound.Length; i++)
            {
                WriteLine($"{filesFound[i]}\n");
            }
            //Method to copy each file found.
            newLocation = c.CopyFile(filesFound);
            WriteLine("Your files have been saved to: {0}", newLocation);
            ReadKey();
        }      
       
    }
}
