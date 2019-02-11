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

        Character2[] character2 = {
            new Warrior2(),
            new Archer2(),
            new Mage2()
            };

        Character1[] character1 =
        {
            new Warrior(),
            new Archer(),
            new Mage()
        };

        /*Character2 wa2 = new Warrior2();
        Character2 ma2 = new Mage2();
        Character2 ar2 = new Archer2();*/




        /*private struct Position{ public int pos1, pos2; }
        Position p = new Position();*/

        static void Main(string[] args)
        {                       
            Game gm = new Game();
            
            int inClass1, inClass2, command;
            int pos1 = 0;
            int pos2 = 0;
            string input;
            char cmd = 'n';
            bool end = false;
            bool test = false;

            WriteLine("Chose player 1 class \n" +
            "M = mage \n W = Warrior \n  A = Archer \n");
            input = ReadLine();
            inClass1 = gm.ChoseCharacter(input);
            //requests input for character choice.
            WriteLine("Chose player 2 class \n" +
           "M = mage \n W = Warrior \n  A = Archer \n");
            input = ReadLine();
            inClass2 = gm.ChoseCharacter(input);
            while (end == false)
            {
                int player = 1;
                //provides a description or characters and abilities for current player.
                end = gm.Discription(inClass1, inClass2, player, ref pos1);
                input = ReadLine();
                int.TryParse(input, out command);
                if (command == 1)
                {
                    test = false;
                    while (test == false)
                    {//checks and requests movement input
                        gm.Movement(inClass1, player, ref test, ref pos1);                        
                    }
                    test = false;
                    while(test == false)
                    {//calls attack after movement.
                        WriteLine("Woult you like to attack Y/N ?");
                        input = ReadLine();
                        test = char.TryParse(input, out cmd);
                    }
                    gm.CallAttack(cmd, inClass1, inClass2, player);
                }
                if(command == 2)
                {//calls special attack.
                    WriteLine(gm.CallSpecial(inClass1, inClass2, player));
                }
                //changes the player number to make it possible to use the same functions.
                player = 2;
                end = gm.Discription(inClass2, inClass1, player, ref pos2);
                input = ReadLine();
                int.TryParse(input, out command);
                if(command == 1)
                {
                    test = false;
                    while (test == false)
                    {//movement
                        gm.Movement(inClass1, player, ref test, ref pos1);
                    }
                    test = false;
                    while (test == false)
                    {//attack calls
                        WriteLine("Woult you like to attack Y/N ?");
                        input = ReadLine();
                        test = char.TryParse(input, out cmd);
                    }
                    gm.CallAttack(cmd, inClass2, inClass1, player);
                }
                if (command == 2)
                {//speical call
                    WriteLine( gm.CallSpecial(inClass2, inClass1, player));
                }
            }
        }

        //sets the index for which character the the user chose.
        int ChoseCharacter(string input)
        {
            string Test;
            char transvar = '0';
            int output = 0;
            bool test;
            test = char.TryParse(input, out transvar);
            //runs if input is incorrect.
            if ((input == "") || (test == false))
            {
                while (test == false)
                {                    
                    test = char.TryParse(input, out transvar);
                    WriteLine("Enter a letter either a, m, or w.");
                    Test = ReadLine();

                    switch (transvar)
                    {
                        case 'w':
                            output = 0;
                            test = true;
                                break;
                        case 'W':
                            output = 0;                            
                            test = true;
                            break;
                        case 'a':
                            output = 1;
                            test = true;
                            break;
                        case 'A':
                            output = 1;
                            test = true;
                            break;
                        case 'm':
                            output = 2;
                            test = true;
                            break;
                        case 'M':
                            output = 2;
                            test = true;
                            break;
                        default:
                            WriteLine("You're doing it wrong.");
                            break;
                    }
                }
                return output;
            }
            else
            {
                switch (transvar)
                {
                    case 'w':
                        output = 0;
                        break;
                    case 'W':
                        output = 0;
                        break;
                    case 'a':
                        output = 1;
                        break;
                    case 'A':
                        output = 1;
                        break;
                    case 'm':
                        output = 2;
                        break;
                    case 'M':
                        output = 2;
                        break;
                }
                return output;
            }
        }

        //returns character and health discriptions
        bool Discription(int charIndex, int charIndex2, int player, ref int position) {
            string output = null;
            bool end = false;
            string[] character = { "Warrior", "Archer", "Mage" };
            if (player == 1)
            {//checks health of both players.
                if(character1[charIndex].Health <= 0)
                {
                    end = true;
                }
                //return for player 1.
                output = $"Player 1 Class = {character[charIndex]}, Health = {character1[charIndex].Health}"+
                    $" Player2 Class = {character[charIndex2]}, Health = {character2[charIndex2].Health} \n \n";
                output += $"1. Move and Attack ({character1[charIndex].GetMovementAttackDescription()})\n";
                output += $"wa1. Special ({character1[charIndex].GetSpecialDescription()})";
                position = character1[charIndex].Position;
            }
            if (player == 2)
            {
                if (character2[charIndex].Health <= 0)
                {
                    end = true;
                }
                //return for player 2
                output = $"Player 2 Class = {character[charIndex]}, Health = {character2[charIndex].Health}" +
                    $" Player1 Class = {character[charIndex2]}, Health = {character1[charIndex2].Health} \n \n";
                output += $"1. Move and Attack ({character2[charIndex].GetMovementAttackDescription()})\n";
                output += $"wa1. Special ({character2[charIndex].GetSpecialDescription()})";
                position = character2[charIndex].Position;
            }
            if (output != null)
            {
                WriteLine($"{output} \n");
                
            }
            return end;
        }
                     
        //Call to move a players character
        void Movement(int character, int player, ref bool testvar, ref int position)
        {
            string input;            
            int move;
            while (testvar == false)
            {
                WriteLine("How far would you like to move?");
                input = ReadLine();

                //tests for correct input.
                if (int.TryParse(input, out move) == false)
                {
                    WriteLine("You must enter a number.");
                    testvar = false;
                }

                //tests for movement within range of the board
                if (((position + move) >= 0) || ((position + move) <= 50))
                {
                    position += move;
                    CommitMove(character, player, move, ref testvar, ref position);
                    testvar = true;

                }
                else
                {       //if the movement is outside of the board this returns false.
                    if ((position + move) > 50)
                    {
                        WriteLine("You must move a negative number, board length is 0 to 50.");
                        testvar = false;
                    }
                    if ((position + move) < 0)
                    {
                        WriteLine("You must move a positive number, board length is 0 to 50.");
                        testvar = false;
                    }
                    else { testvar = false; }
                }
            }
        }

        //commits the position to the called character class, also tests for allowed movement distance.
        void CommitMove(int character, int player, int movement, ref bool testvar1, ref int position)
        {
            //tests and appends position and movement for player1's character.
            if (player == 1)
            {
                if (movement <= character1[character].MoveSpeed)
                {
                    position += movement;
                    character1[character].Position = position;
                }
                else { WriteLine($"You must enter a distance of {character1[character].MoveSpeed} or less."); testvar1 = false; }
            } //tests and appends position and movement for player1's character.
            if (player == 2)
            {
                if (movement <= character2[character].MoveSpeed)
                {
                    position += movement;
                    character2[character].Position = position;
                }
                else { WriteLine($"You must enter a distance of {character2[character].MoveSpeed} or less."); testvar1 = false; }

            }
        }
        //calls attack from respective class
        void CallAttack(char command, int ch1, int ch2, int character ) {
            if ((command == 'y') || (command == 'Y'))
            {//seperates each call by class.
                if (character == 1)
                {
                    WriteLine(character1[ch1].Attack(character2[ch2]));
                }
                if (character == 2)
                {
                    WriteLine(character2[ch1].Attack(character1[ch2]));
                }
            }
        }

        string CallSpecial(int ch1, int ch2, int player)
        {
            if (player == 1)
            {
                string output;
                output = character1[ch1].Special(character2[ch2]);
                return output;
            }
            if (player == 2)
            {
                string output;
                output = character2[ch1].Special(character1[ch2]);
                return output;
            }
            else { return "Error william robinson."; }
        }       
    }
}
