using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma_Machine
{
    class LtSeq : ISequence<T>
    {
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

        List<int> Reflector = new List<int>()
        {
            3,6,8,0,5,4,1,9,2,7
        };


        public int ScrambleSequence(bool[] rotorSeq, int chngNum)
        {
            int retVal = chngNum;

            try
            {
                if (rotorSeq[0] == true)
                {
                    retVal = Rotor1Chng(chngNum);
                }
                if (rotorSeq[1] == true)
                {
                    retVal = Rotor2Chng(retVal);
                }
                if (rotorSeq[2] == true)
                {
                    retVal = Rotor3Chng(retVal);
                }
                if (rotorSeq[3] == true)
                {
                    retVal = Rotor4Chng(retVal);
                }
                retVal = Reflector[retVal];

            }
            catch (Exception)
            {      }

            return retVal;
        }
        
        int Rotor1Chng(int shiftyVal)
        {
            int retVal;
            retVal = Rotor1[shiftyVal];
            return retVal;
        }
        int Rotor2Chng(int shiftyVal)
        {
            int retVal;
            retVal = Rotor2[shiftyVal];
            return retVal;
        }
        int Rotor3Chng(int shiftyVal)
        {
            int retVal;
            retVal = Rotor3[shiftyVal];
            return retVal;
        }
        int Rotor4Chng(int shiftyVal)
        {
            int retVal;
            retVal = Rotor4[shiftyVal];
            return retVal;
        }
        int Reflect(int shiftyVal)
        {
            int retVal;
            retVal = Reflector[shiftyVal];
            return retVal;
        }

        public void RotateRotors(int rotorNum, int numberOfRotations)
        {
            try
            {
                ResetRotors(rotorNum, numberOfRotations);

                if ((numberOfRotations <= 9) && (numberOfRotations >= 0))
                {
                    switch (rotorNum)
                    {
                        case 1:
                            for (int i = 0; i < numberOfRotations; i++)
                            {
                                for (int j = 0; j < Rotor1.Count; j++)
                                {
                                    if (Rotor1[j] >= 9)
                                    {
                                        Rotor1[j] = 0;
                                    }
                                    else
                                    {
                                        Rotor1[j]++;
                                    }
                                }
                            }
                            break;
                        case 2:
                            for (int i = 0; i < numberOfRotations; i++)
                            {
                                for (int j = 0; j < Rotor2.Count; j++)
                                {
                                    if (Rotor2[j] >= 9)
                                    {
                                        Rotor2[j] = 0;
                                    }
                                    else
                                    {
                                        Rotor2[j]++;
                                    }
                                }
                            }
                            break;
                        case 3:
                            for (int i = 0; i < numberOfRotations; i++)
                            {
                                for (int j = 0; j < Rotor3.Count; j++)
                                {
                                    if (Rotor3[j] >= 9)
                                    {
                                        Rotor3[j] = 0;
                                    }
                                    else
                                    {
                                        Rotor3[j]++;
                                    }
                                }
                            }
                            break;
                        case 4:
                            for (int i = 0; i < numberOfRotations; i++)
                            {
                                for (int j = 0; j < Rotor4.Count; j++)
                                {
                                    if (Rotor4[j] >= 9)
                                    {
                                        Rotor4[j] = 0;
                                    }
                                    else
                                    {
                                        Rotor4[j]++;
                                    }
                                }
                            }
                            break;
                        default:
                            break;
                    }
                }
            }            
            catch (Exception e) {    }
        }

        void ResetRotors(int rotorNum, int numberOfRotations)
        {
            switch (rotorNum)
            {
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
