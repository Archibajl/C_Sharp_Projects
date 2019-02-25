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
        static void Main(string[] args)
        {
            int Selection;
            string Input;
            string[] SearchDir;
            WriteLine(" Enter an option: \n 1. Scan for Videos. \n 2. Scan for Audio. \n 3. Scan for Images \n 4. Scan for All. " +
                "\n 5. Exit.");
            Input = ReadLine();
            int.TryParse(Input, out Selection);
            
        }

        void SearchSelec(int Select)
        {
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
                default:
                    WriteLine("Don't be a fool follow the rules.");
                    break;
            }
        }

    }
}
