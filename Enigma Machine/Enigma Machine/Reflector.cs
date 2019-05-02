using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma_Machine
{
    class Reflection
    {
        //Returns the reflector output.
        List<int> Reflector = new List<int>()
        {
            3,6,8,0,5,4,1,9,2,7
        };

        public int Reflect(int shiftyVal)
        {
            int retVal;
            retVal = Reflector[shiftyVal];
            return retVal;
        }
    }
}
