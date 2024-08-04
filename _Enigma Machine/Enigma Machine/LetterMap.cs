using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Enigma_Machine
{
    internal class LetterMap
    {
        public int mapToNumber(char letter)
        {
            switch (letter)
            {
                case 'a':
                    return 10;
                case 'b':
                    return 11;
                case 'c':
                    return 12;
                case 'd':
                    return 13;
                case 'e':
                    return 14;
                case 'f':
                     return 15;
                case 'g':
                     return 16;
                case 'h':
                     return 17;
                case 'i':
                     return 18;
                case 'j':
                     return 19;
                case 'k':
                     return 20;        
                case 'l':
                     return 21;
                case 'm':
                     return 22;
                case 'n':
                     return 23;
                case 'o':
                     return 24;
                case 'p':
                     return 25;
                case 'q':
                     return 26;
                case 'r':
                     return 27;
                case 's':
                     return 28;
                case 't':
                     return 29;
                case 'u':
                     return 30;
                case 'v':
                     return 31;
                case 'w':
                     return 32;
                case 'x':
                     return 33;
                case 'y':
                     return 34;
                case 'z':
                    return 35;
                default: 
                    return int.Parse(letter.ToString());
            }
        }

        public char mapToChar(int map)
        {
            switch (map)
            {
                case 10: 
                    return 'a';
                case 11:
                    return 'b';
                case 12:
                    return 'c';
                case 13:
                    return 'd';
                case 14:
                    return 'e';
                case 15:
                    return 'f';
                case 16:
                    return 'g';
                case 17:
                    return 'h';
                case 18:
                    return 'i';
                case 19:
                    return 'j';
                case 20:
                    return 'k';
                case 21:
                    return 'l';
                case 22:
                    return 'm';
                case 23:
                    return 'n';
                case 24:
                    return 'o';
                case 25:
                    return 'p';
                case 26:
                    return 'q';
                case 27:
                    return 'r';
                case 28:
                    return 's';
                case 29:
                    return 't';
                case 30:
                    return 'u';
                case 31:
                    return 'v';
                case 32:
                    return 'w';
                case 33:
                    return 'x';
                case 34:
                    return 'y';
                case 35:
                    return 'z';
                default:
                    return (char) map;
            }
        }
    }
}
