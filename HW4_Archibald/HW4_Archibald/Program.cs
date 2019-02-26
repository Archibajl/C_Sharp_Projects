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
        IMedia<M> m = new {
            Audio A = new Audio();
            Video V = new Video();
            Image I = new Image();
        }
        static void Main(string[] args)
        {
            Program pr = new Program();
            bool exit = false;
            int selection;
            string Input;
            string[] SearchDir;
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
            bool exitVal = false;
            switch (Select)
            {
                case 1:

                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
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
