using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HW4_Archibald
{
    class Video : Search, IMedia<Video>
    {
        Data<Video> dv = new Data<Video>();
            
        int Length;
       

        public void Search(string directory)
        {
            // sorts by file types listed.
            string[] fileTypes = { ".avi", ".mp4" };

            dv.Search(directory, fileTypes);            
        }

        public void LibraryMenu()
        {
            int selection1;
            int selection2 = 0;
            string[] fileTypes = { ".avi", ".mp4" };
            PrintValues();
            Console.WriteLine("\n 1. Sort by name. \n 2. Sort by extention. \n 3. Sort by date last accessed. \n 4. Touch/ update date accessed of file. \n" +
                    "5. Remove file.");
            string input = Console.ReadLine();
            int.TryParse(input, out selection1);
            //Selects the command and calls the appropriate functions.
            switch (selection1)
            {
                case 1: //Sorts by name
                    Console.WriteLine("Sorting by name.");
                    dv.SortName();
                    PrintValues();
                    break;
                case 2:// sorts by extention
                    Console.WriteLine("Sorting by extention.");
                    dv.SortFType(fileTypes);
                    PrintValues();
                    break;
                case 3: // sorts by date last accessed
                    Console.WriteLine("Sorting by date last accessed.");
                    dv.SortAccDate();
                    PrintValues();
                    break;
                case 4:
                    Console.WriteLine("Enter an index to update the date accessed.");
                    input = Console.ReadLine();
                    int.TryParse(input, out selection2);
                    dv.TouchIndex(selection2);
                    PrintSingleValue(selection2);
                    break;
                case 5: //Removes file
                    Console.WriteLine("Enter an index to remove.");
                    input = Console.ReadLine();
                    int.TryParse(input, out selection2);
                    dv.RemoveValue(selection2);
                    Console.WriteLine("Index {0} removed", selection2);
                    PrintValues();
                    break;
                default:
                    Console.WriteLine("Try again friend.");
                    break;
            }
        }

        public void Remove(int Index)
        {
            //Removes selected index.
            dv.RemoveValue(Index);
        }
                    
        public void PrintValues()
        {
            //Prints stored values
            Length = dv.FileName.Length;

            for (int i = 0; i < Length; i++)
            {
                Console.WriteLine($"{i}, File Name: {dv.FileName[i]}\n File Extention {dv.FileExtention[i]} \n Date Last accessed {dv.DateLastAccessed[i]}");
            }
        }

        public void PrintSingleValue(int index)
        {
            Console.WriteLine("Updated.");
            Console.WriteLine($"{index}. File Name: {dv.FileName[index]}\n File Extention {dv.FileExtention[index]} \n Date Last accessed {dv.DateLastAccessed[index]}");
        }
    }
}
