//Justin Archibald
//CSC3020
//HW 4

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HW4_Archibald
{
    class Program 
    {
        //initializing each media type.
        IMedia<Video> Vid = new Video();
        IMedia<Image> Img = new Image();
        IMedia<Audio> Aud = new Audio();

        static void Main(string[] args)
        {
            Program pr = new Program();
            bool exit = false;
            int selection;
            string Input;
            //Loops until selected to exit.
            while (exit == false)
            {
                WriteLine(" Enter an option: \n 1. Scan for Videos. \n 2. Scan for Audio. \n 3. Scan for Images \n 4. Scan for All. " +
                    "\n 5. Access Video Library. \n 6. Access Audio Library. \n 7. Access image library. \n 8. Exit.");
                Input = ReadLine();
                int.TryParse(Input, out selection);
                //Calls the menu.
                exit = pr.SearchSelect(selection);
            }
        }

        bool SearchSelect(int Select)
        {
            string input;
            bool exitVal = false;
            switch (Select)
            {
                case 1: //Searches for Video Files.
                    WriteLine("Enter the directory to search.");
                    input = @ReadLine();
                    Vid.Search(input);
                    break;
                case 2: //searches for audio files.
                    WriteLine("Enter the directory to search.");
                    input = @ReadLine();
                    Aud.Search(input);
                    break;
                case 3: // searches for images.
                    WriteLine("Enter the directory to search.");
                    input = @ReadLine();
                    Img.Search(input);
                    break;
                case 4: //Searches for all types of media.
                    WriteLine("Enter the directory to search.");
                    input = @ReadLine();
                    Vid.Search(input);
                    Aud.Search(input);
                    Img.Search(input);
                    break;
                case 5://Library menues for each media type.
                    Vid.LibraryMenu();
                    break;
                case 6:
                    Aud.LibraryMenu();
                    break;
                case 7:
                    Img.LibraryMenu();
                    break;
                case 8:
                    exitVal = true;
                    break;
                default: //default inproper input.
                    WriteLine("Don't be a fool follow the rules.");
                    break;
            }
            return exitVal;
        }
    }
}
