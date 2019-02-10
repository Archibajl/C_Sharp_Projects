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
        Character1 w1 = new Warrior();
        Character1 m1 = new Mage();
        Character1 a1 = new Archer();
        struct Position{int Ch1, Ch2; char class1, class2 };

        static void Main(string[] args)
        {
            
            
            Game gm = new Game();
            char inClass1, inClass2;
            string input;

            WriteLine("Chose player 1 class " +
            "M = mage /n W = Warrior /n  A = Archer /n");
            input = ReadLine();
            char.TryParse(input, out inClass1);
            WriteLine("Chose player 2 class " +
           "M = mage /n W = Warrior /n  A = Archer /n");
            input = ReadLine();
            char.TryParse(input, out inClass2);
            //while ()
            

        }
        void determineCharacter(char characterChoice)
        {
            
        }

    }
}
