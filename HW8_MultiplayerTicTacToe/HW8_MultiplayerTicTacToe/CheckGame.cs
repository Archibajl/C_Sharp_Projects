using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8_MultiplayerTicTacToe
{
    class CheckGame
    {
        char RetChar;

        public bool CheckBoard(char[,] Board, ref char winningVal)
        {
            //bool retVal = true;
            if (CheckDiagnal(Board) || CheckRows(Board) || CheckCollumns(Board))
            {
                winningVal = RetChar;
                return true;
            }
            else
            {
                    return false;
            }
        }        

        //Checks rows for the same value;
        bool CheckRows(char[,] Board)
        {
            for (int i = 0; i < 3; i++)
            {
                if (CheckChars(Board[i, 0], Board[i, 1], Board[i, 2]))
                {
                    return true;
                }
            }

            return false;
        }

        //Checks collumns for the same value.
        bool CheckCollumns(char[,] Board)
        {
            for (int i = 0; i < 3; i++)
            {
                if (CheckChars(Board[0, i], Board[1, i], Board[2, i]))
                {
                    return true;
                }
            }

            return false;
        }

        //Checks Diagonal values.
        bool CheckDiagnal(char[,] Board)
        {
            if (CheckChars(Board[0, 0], Board[1, 1], Board[2, 2]))
                return true;

            if (CheckChars(Board[0, 2], Board[1, 1], Board[2, 0]))
                return true;

            return false;
        }

        //Checks if the characters of the line are the same value.
        bool CheckChars(char ch1, char ch2, char ch3)
        {
            if ((ch1 != '\0'))
            {
                if ((ch1 == ch2) && (ch2 == ch3))
                {
                    RetChar = ch1;
                    return true;
                }
            }

            return false;
        }
    }
}
