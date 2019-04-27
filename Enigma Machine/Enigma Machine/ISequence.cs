using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma_Machine
{
    interface ISequence<T>
    {
        int ScrambleSequence(bool[] rotorSeq, int chngNum);
               
        void RotateRotors(int rotorNum, int numberOfRotations);
               
    }
}
