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
            string[] fileTypes = { ".avi", ".mp4" };

            dv.Search(directory, fileTypes);            
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
                    dv.SortName();
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    Console.WriteLine("Enter an index to update the date accessed.");
                    input = Console.ReadLine();
                    int.TryParse(input, out selection2);
                    dv.TouchIndex(selection2);
                    break;
                case 5: //Removes file
                    Console.WriteLine("Enter an index to remove.");
                    input = Console.ReadLine();
                    int.TryParse(input, out selection2);
                    dv.RemoveValue(selection2);
                    break;
                default:
                    Console.WriteLine("Try again friend.");
                    break;
            }
        }

        public void Remove(int Index)
        {
            dv.RemoveValue(Index);
        }
                    
        public void PrintValues()
        {
            Length = dv.FileName.Length;

            for (int i = 0; i < Length; i++)
            {
                Console.WriteLine($"File Name: {dv.FileName[i]}\n File Extention {dv.FileExtention[i]} \n Date Last accessed {dv.DateLastAccessed[i]}");
                //Console.WriteLine($" Index: {i} \n File name: {FileName} \n File Extention: {FileExtention}\n Date Last Accessed {DateLastAccessed}");
            }
        }

        
    }
}
