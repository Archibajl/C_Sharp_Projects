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
        private Character1 wa1 = new Warrior();
        private Character1 ma1 = new Mage();
        private Character1 ar1 = new Archer();
        private Character2 wa2 = new Warrior2();
        private Character2 ma2 = new Mage2();
        private Character2 ar2 = new Archer2();
                
        /*private struct Position{ public int pos1, pos2; }
        Position p = new Position();*/

        static void Main(string[] args)
        {                       
            Game gm = new Game();            
            char inClass1, inClass2;
            int command;
            int pos1 = 0;
            int pos2 = 0;
            string input;
            bool end = false;
            bool test = false;
            WriteLine("Chose player 1 class \n" +
            "M = mage \n W = Warrior \n  A = Archer \n");
            input = ReadLine();
            char.TryParse(input, out inClass1);

            WriteLine("Chose player 2 class \n" +
           "M = mage \n W = Warrior \n  A = Archer \n");
            input = ReadLine();            
            char.TryParse(input, out inClass2);
            while (end == false)
            {
                int player = 1;
                gm.Discription(inClass1, player, ref pos1);
                input = ReadLine();
                int.TryParse(input, out command);
                if (command == 1)
                {
                    while (test == false)
                    {
                        gm.Movement(inClass1, player, ref test, ref pos1);
                    }
                }

                player = 2;
                gm.Discription(inClass2, player, ref pos2);
                input = ReadLine();
                int.TryParse(input, out command);
                if (command == 1)
                {
                    while (test == false)
                    {
                        gm.Movement(inClass1, player, ref test, ref pos1);
                    }
                }
            }
            

        }

        void Discription(char Character, int player, ref int position)
        {
            
            string output = null;
            if (player == 1)
            {
                switch (Character)
                {
                    case 'w':
                        output = $"1. Move and Attack ({wa1.GetMovementAttackDescription()})\n";
                        output += $"2. Special ({wa1.GetSpecialDescription()})";
                        position = wa1.Position;
                        break;
                    case 'a':
                        output = $"1. Move and Attack ({ar1.GetMovementAttackDescription()})\n";
                        output += $"2. Special ({ar1.GetSpecialDescription()})";
                        position = ar1.Position;
                        break;
                    case 'm':
                        output = $"1. Move and Attack ({ma1.GetMovementAttackDescription()})\n";
                        output += $"2. Special ({ma1.GetSpecialDescription()})";
                        position = ma1.Position;
                        break;
                }
            }
            if(player == 2){
                switch (Character)
                {
                    case 'w':
                        output = $"1. Move and Attack ({wa2.GetMovementAttackDescription()})\n";
                        output += $"2. Special ({wa2.GetSpecialDescription()})";
                        position = wa2.Position;
                        break;
                    case 'a':
                        output = $"1. Move and Attack ({ar2.GetMovementAttackDescription()})\n";
                        output += $"2. Special ({ar2.GetSpecialDescription()})";
                        position = ar2.Position;
                        break;
                    case 'm':
                        output = $"1. Move and Attack ({ma2.GetMovementAttackDescription()})\n";
                        output += $"2. Special ({ma2.GetSpecialDescription()})";
                        position = ma2.Position;
                        break;
                }
            }
            if(output != null) {
                WriteLine($"{output} \n");
            }
        }

        //Call to move a players character
        void Movement(char character, int player, ref bool testvar, ref int position)
        {
            string input;
            int move;
            WriteLine("How far would you like to move?");
            input = ReadLine();

            //tests for correct input.
            if (int.TryParse(input, out move) == false)
            {
                WriteLine("You must enter a number.");
                testvar = false;
            }

            //tests for movement within range of the board
            if (((position >= 0) && (move > -1)) || ((position <= 50) && (move < 1)))
            {
                position += move;
                CommitMove(character, player, move, ref testvar, ref position);
                testvar = true;
                
            }
            else
            {       //if the movement is outside of the board this returns false.
                if ((position < 50) && (move > 1))
                {
                    WriteLine("You must move a negative number, board length is 0 to 50.");
                    testvar = false;
                }
                if ((position == 0) && (move < 0))
                {
                    WriteLine("You must move a positive number, board length is 0 to 50.");
                    testvar = false;
                }
                else { testvar = false; }
            }
        }


        void CommitMove(char character, int player, int movement, ref bool testvar1, ref int position)
        {
            if (player == 1)
            {
                switch (character)
                {
                    case 'w':
                        if (movement <= wa1.MoveSpeed)
                        {
                            position += movement;
                            wa1.Position = position;
                        }
                        else { WriteLine($"You must enter a distance of {wa1.MoveSpeed} or less."); testvar1 = false; }
                        break;
                    case 'a':
                        if (movement <= ar1.MoveSpeed)
                        {
                            position += movement;
                            ar1.Position = position;
                        }
                        else { WriteLine($"You must enter a distance of {ar1.MoveSpeed} or less."); testvar1 = false; }                        
                        break;
                    case 'm':
                        if (movement <= ma1.MoveSpeed)
                        {
                            position += movement;
                            ma1.Position = position;
                        }
                        else { WriteLine($"You must enter a distance of {ma1.MoveSpeed} or less."); testvar1 = false; }
                        break;
                }
            }
            if (player == 2)
            {
                switch (character)
                {
                    case 'w':
                        if (movement <= wa2.MoveSpeed)
                        {
                            position += movement;
                            wa2.Position = position;
                        }
                        else { WriteLine($"You must enter a distance of {wa2.MoveSpeed} or less."); testvar1 = false; }
                        break;
                    case 'a':
                        if (movement <= ar2.MoveSpeed)
                        {
                            position += movement;
                            ar2.Position = position;
                        }
                        else { WriteLine($"You must enter a distance of {ar2.MoveSpeed} or less."); testvar1 = false; }
                        break;
                    case 'm':
                        if (movement <= ma2.MoveSpeed)
                        {
                            position += movement;
                            ma2.Position = position;
                        }
                        else { WriteLine($"You must enter a distance of {ma2.MoveSpeed} or less."); testvar1 = false; }
                        break;
                }
            }
        }

        void CallAttack() {

        }
    }
}
