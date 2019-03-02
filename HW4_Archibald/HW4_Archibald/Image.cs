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
            string[] fileTypes = { ".jpg", ".png", ".gif" };

            di.Search(directory, fileTypes);
            
        }

        public void LibraryMenu()
        {
            int selection1;
            int selection2 = 0;
            PrintValues();
            Console.WriteLine(" 1. Sort by name. \n 2. Sort by extention. \n 3. Sort by date last accessed. \n 4. Touch/ update date accessed of file. \n" +
                    "5. Remove file.");
            string input = Console.ReadLine();
            int.TryParse(input, out selection1);

            switch (selection1)
            {
                case 1:
                    Console.WriteLine("Enter an index to update.");
                    input = Console.ReadLine();
                    int.TryParse(input, out selection2);
                    di.SortName();
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    Console.WriteLine("Enter an index to update the date accessed.");
                    input = Console.ReadLine();
                    int.TryParse(input, out selection2);
                    di.TouchIndex(selection2);
                    break;
                case 5: //Removes file
                    Console.WriteLine("Enter an index to remove.");
                    input = Console.ReadLine();
                    int.TryParse(input, out selection2);
                    di.RemoveValue(selection2);
                    break;
                default:
                    Console.WriteLine("Try again friend.");
                    break;
            }
        }

        public void Remove(int Index)
        {
            di.RemoveValue(Index);
        }

        public void PrintValues()
        {
            Length = di.FileName.Length;

            for (int i = 0; i < Length; i++)
            {
                Console.WriteLine($"{i}. File Name: {di.FileName[i]}\n File Extention {di.FileExtention[i]} \n Date Last accessed {di.DateLastAccessed[i]}");
            }
        }
        
    }
}
