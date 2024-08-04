using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma_Machine
{
    internal class ReelSequence : ReelFunctionality //: ISequence<RtSeq>
    {

        //Instantiates the Rotors
        public ReelSequence()
        { //Mapings originate from Wikipidia Enigma rotor Details
            //https://en.wikipedia.org/wiki/Enigma_rotor_details
            //0-9 are randomly mapped followed by alphabetic characters.

            state = new Stack<List<List<int>>>();
            reel = new List<List<int>>();

            reel.Add(new List<int>{//RotorI EnigmaI
                1,3,6,0,5,4,8,7,9,2,14,20,22,15,21,16,13,26,31,35,23,29,24,32,34,17,33,30,28,25,10,18,11,27,12,19
            });
            reel.Add(new List<int>{//RotorII EnigmaI
                0,3,5,2,6,9,1,4,8,7,10,19,13,20,28,18,27,30,33,11,21,17,32,29,22,12,26,16,35,23,25,34,15,31,24,14
            });
            reel.Add(new List<int> { //RotorIII EnigmaI
                5,9,1,7,3,8,0,2,4,6,11,13,15,17,19,21,12,25,27,29,33,31,35,23,34,14,18,32,16,10,20,22,30,28,26,24
            });
            reel.Add(new List<int>{ //RotorIV M3 Army
                1,6,5,2,9,0,7,4,3,8,14,28,24,31,25,35,19,10,34,26,30,18,27,17,33,21,23,15,29,16,20,13,12,22,32,11
            });

            setState();
        }

        //Returns the output from the position on the rotor.
        public int ScrambleSequenceFwd(int inputNumber)
        {
            //Return current reel value
            return GetCurrentSequenceAndIncrement(inputNumber);
        }

        //Returns the position from the output of the rotor.
        public int ScrambleSequenceRev(int inputNumber)
        {
            return GetPreviousSequence(inputNumber);
        }

        //Returns the output depending on the input position.
        public void IncrementRotors(int reel, int incrementBy)
        {
            IncrementRotor(reel, incrementBy);
        }

       
        public void DecrementRotors()
        {
            DecrementReel();
        }

        
    }
}
