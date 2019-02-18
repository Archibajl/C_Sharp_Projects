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
             WriteLine("To search and copy enter a directory to search.");
             directory = @ReadLine();
             WriteLine("Enter a filetype to copy.");
             fileType = ReadLine();             
             filesFound = f.ReturnFilePath(directory, fileType);
            WriteLine("Files to be copied: \n");
            for(int i= 0; i< filesFound.Length; i++)
            {
                WriteLine($"{filesFound[i]}\n");
            }
            newLocation = c.CopyFile(filesFound);
            WriteLine("Your files have been saved to: {0}", newLocation);
            ReadKey();
        }      
       
    }
}
