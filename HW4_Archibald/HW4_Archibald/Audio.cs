using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HW4_Archibald
{
    class Audio : Search, IMedia<Audio>
    {
        Data<Audio> da = new Data<Audio>();        

        int Length;
        
        //searches for each file type.
        public void Search(string directory)
        {
            //Searches for each filetype listed.
            string[] fileTypes = { ".mp3", ".wav", ".wma" };

            da.Search(directory, fileTypes);
        
        }

        public void LibraryMenu()
        {
            int selection1;
            int selection2 = 0;
            PrintValues();
            Console.WriteLine("\n 1. Sort by name. \n 2. Sort by extention. \n 3. Sort by date last accessed. \n 4. Touch/ update date accessed of file. \n" +
                    "5. Remove file.");
            string input = Console.ReadLine();
            int.TryParse(input, out selection1);
            string[] fileTypes = { ".mp3", ".wav", ".wma" };           

            switch (selection1)
            {
                case 1://Sorts the list by name.
                    Console.WriteLine("Sorting by name.");                    
                    da.SortName();
                    PrintValues();
                    break;
                case 2: //Sorts by file type
                    Console.WriteLine("Sorting by extention.");
                    da.SortFType(fileTypes);
                    PrintValues();
                    break;
                case 3: //Sorts by date last accessed
                    Console.WriteLine("Sorting by date last accessed.");
                    da.SortAccDate();
                    PrintValues();
                    break;
                case 4:
                    //Updates time of last access for a selected file.
                    Console.WriteLine("Enter an index to update the date accessed.");
                    input = Console.ReadLine();
                    int.TryParse(input, out selection2);
                    da.TouchIndex(selection2);
                    PrintSingleValue(selection2);
                    break;
                case 5: //Removes file.
                    Console.WriteLine("Enter an index to remove.");
                    input = Console.ReadLine();
                    int.TryParse(input, out selection2);
                    da.RemoveValue(selection2);
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
            //Removes an index from the list.
            da.RemoveValue(Index);
            PrintValues();
        }

        public void PrintValues()
        {
            //Prints each value from the stored values
            Length = da.FileName.Length;

            for (int i = 0; i < Length; i++)
            {
                Console.WriteLine($"{i}. File Name: {da.FileName[i]}\n File Extention {da.FileExtention[i]} \n Date Last accessed {da.DateLastAccessed[i]}");
            }
        }

        public void PrintSingleValue(int index)
        {
            Console.WriteLine("Updated.");
            Console.WriteLine($"{index}. File Name: {da.FileName[index]}\n File Extention {da.FileExtention[index]} \n Date Last accessed {da.DateLastAccessed[index]}");
        }
        
    }
}
