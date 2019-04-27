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

        int Rotor1Chng(int shiftyVal);
        int Rotor2Chng(int shiftyVal);
        int Rotor3Chng(int shiftyVal);
        int Rotor4Chng(int shiftyVal);

        void RotateRotors(int rotorNum, int numberOfRotations);

        void ResetRotors(int rotorNum, int numberOfRotations);
    }
}
