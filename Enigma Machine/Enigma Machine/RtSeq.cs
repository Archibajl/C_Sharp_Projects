using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma_Machine
{
    class RtSeq : ISequence<RtSeq>
    {
        private int rotCounter = 0;

        List<int> Rotor1 = new List<int>()
        {
            1,3,6,0,5,4,8,7,9,2
        };

        List<int> Rotor2 = new List<int>()
        {
            0,3,5,2,6,9,1,4,8,7
        };

        List<int> Rotor3 = new List<int>()
        {
            5,9,1,7,3,8,0,2,4,6
        };

        List<int> Rotor4 = new List<int>()
        {
            1,6,5,2,9,0,7,4,3,8
        };


        public int RotationCounter
        {
            get { return rotCounter; }
            set { rotCounter = value; }
        }

        //Returns the output from the position on the rotor.
        public int ScrambleSequenceFwd(int rotorNum, int chngNum)
        {
            int retVal = chngNum;

            switch (rotorNum)
            {
                case 1:
                    retVal = RotorChng(Rotor1, retVal);
                    break;
                case 2:
                    retVal = RotorChng(Rotor2, retVal);
                    break;
                case 3:
                    retVal = RotorChng(Rotor3, retVal);
                    break;
                case 4:
                    retVal = RotorChng(Rotor4, retVal);
                    break;
            }

            return retVal;
        }

        //Returns the position from the output of the rotor.
        public int ScrambleSequenceRev(int rotorNum, int chngNum)
        {
            int retVal = chngNum;

            switch (rotorNum)
            {
                case 1:
                    retVal = ReverseRotor(Rotor1, retVal);
                    break;
                case 2:
                    retVal = ReverseRotor(Rotor2, retVal);
                    break;
                case 3:
                    retVal = ReverseRotor(Rotor3, retVal);
                    break;
                case 4:
                    retVal = ReverseRotor(Rotor4, retVal);
                    break;
            }

            return retVal;
        }

        //Returns the output depending on the input position.
        int RotorChng(List<int> Rotor, int shiftyVal)
        {
            int retVal;
            retVal = Rotor[shiftyVal];
            return retVal;
        }

        //Returns the reverse of the output.
        int ReverseRotor(List<int> Rotor, int shiftyVal)
        {
            int retVal;
            retVal = Rotor.IndexOf(shiftyVal);
            return retVal;
        }


        //Rotates the roters output by incrementing each element by 1
        public void RotateRotors(int rotorNum, int numberOfRotations, bool initiisatoin)
        {
            try
            {
                //Resets rotors to their initial value.
                if (initiisatoin == true)
                {
                    ResetRotors(rotorNum, numberOfRotations);
                }
                //Ensures an adequate number of rotations.
                if ((numberOfRotations <= 9) && (numberOfRotations >= 0))
                {
                    switch (rotorNum)
                    {
                        //Selects list to be incremented.
                        case 1:
                            Rotator(ref Rotor1, numberOfRotations);
                            break;
                        case 2:
                            Rotator(ref Rotor2, numberOfRotations);
                            break;
                        case 3:
                            Rotator(ref Rotor3, numberOfRotations);
                            break;
                        case 4:
                            Rotator(ref Rotor4, numberOfRotations);
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (Exception) { }
        }

        //Increments each value of selected list.
        void Rotator(ref List<int> Rotor, int numberOfRotations)
        {
            for (int i = 0; i < numberOfRotations; i++)
            {
                for (int j = 0; j < Rotor.Count; j++)
                {
                    if (Rotor[j] >= 9)
                    {
                        Rotor[j] = 0;
                    }
                    else
                    {
                        Rotor[j]++;
                    }
                }
                //Increments the number of rotations, to tell when the rotor makes a full rotation.
                rotCounter++;
            }
        }

        //Resets rotors to initial values.
        void ResetRotors(int rotorNum, int numberOfRotations)
        {
            switch (rotorNum)
            {
                //Selects rotor to be reset.
                case 1:
                    Rotor1.Clear();
                    Rotor1 = new List<int>{
                                    1,3,6,0,5,4,8,7,9,2
                                };
                    break;
                case 2:
                    Rotor2.Clear();
                    Rotor2 = new List<int>()
                                {
                                    0,3,5,2,6,9,1,4,8,7
                                };
                    break;
                case 3:
                    Rotor3.Clear();
                    Rotor3 = new List<int>()
                                {
                                    5,9,1,7,3,8,0,2,4,6
                                };
                    break;
                case 4:
                    Rotor4.Clear();
                    Rotor4 = new List<int>()
                                {
                                    1,6,5,2,9,0,7,4,3,8
                                };
                    break;
            }
        }

    }
}
