using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HW4_Archibald
{
    class Image : Search, IMedia<Image>
    {

        Data<Image> di = new Data<Image>();
        
        
        public int Length;
        
        public void Search(string directory)
        {
            //searches and stores each file it finds with the selected input.
            string[] fileTypes = { ".jpg", ".png", ".gif" };

            di.Search(directory, fileTypes);
            
        }

        public void LibraryMenu()
        {
            int selection1;
            int selection2 = 0;
            string[] fileTypes = { ".jpg", ".png", ".gif" };
            PrintValues();
            Console.WriteLine("\n 1. Sort by name. \n 2. Sort by extention. \n 3. Sort by date last accessed. \n 4. Touch/ update date accessed of file. \n" +
                    "5. Remove file.");
            string input = Console.ReadLine();
            int.TryParse(input, out selection1);

            //menu for selection.
            switch (selection1)
            {
                case 1: //sorst by name of the file
                    Console.WriteLine("Sorting by name.");                    
                    di.SortName();
                    PrintValues();
                    break;
                case 2: //sorts by file type
                    Console.WriteLine("Sorting by extention.");
                    di.SortFType(fileTypes);
                    PrintValues();
                    break;
                case 3: //sorts by date accessed
                    Console.WriteLine("Sorting by date last accessed.");
                    di.SortAccDate();
                    PrintValues();
                    break;
                case 4: //updates date accessed
                    Console.WriteLine("Enter an index to update the date accessed.");
                    input = Console.ReadLine();
                    int.TryParse(input, out selection2);
                    di.TouchIndex(selection2);
                    PrintSingleValue(selection2);
                    break;
                case 5: //Removes file
                    Console.WriteLine("Enter an index to remove.");
                    input = Console.ReadLine();
                    int.TryParse(input, out selection2);
                    di.RemoveValue(selection2);
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
            //removes an index and it's values
            di.RemoveValue(Index);
        }

        public void PrintValues()
        {
            //prints every line of the stored values for audio.
            Length = di.FileName.Length;

            for (int i = 0; i < Length; i++)
            {
                Console.WriteLine($"{i}. File Name: {di.FileName[i]}\n File Extention {di.FileExtention[i]} \n Date Last accessed {di.DateLastAccessed[i]}");
            }
        }

        public void PrintSingleValue(int index)
        {
            Console.WriteLine("Updated.");
            Console.WriteLine($"{index}. File Name: {da.FileName[index]}\n File Extention {da.FileExtention[index]} \n Date Last accessed {da.DateLastAccessed[index]}");
        }

    }
}
