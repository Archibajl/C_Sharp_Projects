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
        //Character1[] character1 =
        //{
        //    new Warrior(),
        //    new Archer(),
        //    new Mage()
        //};
        IMedia<Video> Vid = new Video();
        IMedia<Image> Img = new Image();
        IMedia<Audio> Aud = new Audio();

        static void Main(string[] args)
        {
            Program pr = new Program();
            bool exit = false;
            int selection;
            string Input;
            //string[] SearchDir;
            while (exit == false)
            {
                WriteLine(" Enter an option: \n 1. Scan for Videos. \n 2. Scan for Audio. \n 3. Scan for Images \n 4. Scan for All. " +
                    "\n 5. Access Video Library. \n 6. Access Audio Library. \n 7. Access image library. \n 8. Exit.");
                Input = ReadLine();
                int.TryParse(Input, out selection);
                exit = pr.SearchSelect(selection);
            }
        }

        bool SearchSelect(int Select)
        {
            string input;
            bool exitVal = false;
            switch (Select)
            {
                case 1:
                    WriteLine("Enter the directory to search.");
                    input = @ReadLine();
                    Vid.Search(input);
                    break;
                case 2:
                    WriteLine("Enter the directory to search.");
                    input = @ReadLine();
                    Aud.Search(input);
                    break;
                case 3:
                    WriteLine("Enter the directory to search.");
                    input = @ReadLine();
                    Img.Search(input);
                    break;
                case 4:
                    WriteLine("Enter the directory to search.");
                    input = @ReadLine();
                    Vid.Search(input);
                    Aud.Search(input);
                    Img.Search(input);
                    break;
                case 5:
                    Vid.PrintValues();
                    break;
                case 6:
                    Aud.PrintValues();
                    break;
                case 7:
                    Img.PrintValues();
                    break;
                case 8:
                    exitVal = true;
                    break;
                default:
                    WriteLine("Don't be a fool follow the rules.");
                    break;
            }
            return exitVal;
        }

    }
}
