using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma_Machine
{
    internal class Reflection
    {
        //Returns the reflector output.
        //Mapings originate from Wikipidia Enigma rotor Details
        //https://en.wikipedia.org/wiki/Enigma_rotor_details
        //0-9 are randomly mapped followed by alphabetic characters.
        private List<int> Reflector = new List<int>()
        {
            3,6,8,0,5,4,1,9,2,7,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35
        };

        public int Reflect(int shiftyVal)
        {
            int retRef;
            retRef = Reflector[shiftyVal];
            return retRef;
        }
    }
}
