//Justin Archibald
//CSC3020
//HW 2

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HW2_Archibald
{
    class Game
    {
        struct Position{int[] Ch1, Ch2; };

        static void Main(string[] args)
        {
            Character1 w1 = new Warrior();
            Character1 m1 = new Mage();
            Character1 a1 = new Archer();
            Game gm = new Game();
            char inClass;
            string input;

            WriteLine("Chose a class " +
            "M = mage /n W = Warrior /n  A = Archer /n");
            input = ReadLine();
            char.TryParse(input, out inClass);

            

        }
        void determineCharacter(char characterChoice)
        {
            
        }

    }
}
