using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma_Machine
{
    internal class ReelFunctionality : ReelOriginator
    {
        private int rotationCounter;
        private int rotorSize;
        private Reflection reflector = new Reflection();
        
        protected int GetCurrentSequenceAndIncrement(int inputNumber)
            {
                int outputNumber = getScrambledOutput(inputNumber); ;
                IncrementReel(1);
                return outputNumber;
            }

            protected int GetPreviousSequence(int inputNumber)
            {
                getState();
                return getScrambledOutput(inputNumber);
            }

            private int getScrambledOutput(int inputNumber)
            {
                int outputNumber = reel[3][reel[2][reel[1][reel[0][inputNumber]]]];
                outputNumber = reflector.Reflect(outputNumber);
                outputNumber = reel[0][reel[1][reel[2][reel[3][outputNumber]]]];
                return outputNumber;
            }

            //Increments each value of selected list.
            protected void IncrementReel(int numberOfRotations)
            {
                setState();
                //Increments the roters based on the number of rotations
                IncrementRotor(3, numberOfRotations);

                if ((rotationCounter % 2) == 0)
                {
                    IncrementRotor(2, numberOfRotations);
                }
                if ((rotationCounter % 4) == 0)
                {
                    IncrementRotor(1, numberOfRotations);
                }
                if ((rotationCounter % 6) == 0)
                {
                    IncrementRotor(0, numberOfRotations);
                }
                rotationCounter++;

            }


            protected void DecrementReel()
            {
                getState();
                rotationCounter--;
            }

            protected void IncrementRotor(int reelNumber, int numberOfRotations)
            {
                if ((reelNumber > 4) || (reelNumber < 0))
                    return;

                for (int i = 0; i < numberOfRotations; i++)
                {
                    List<int> rotor = reel[reelNumber];
                    rotorSize = rotor.Count - 1;
                    for (int j = 0; j <= rotorSize; j++)
                    {
                        try
                        {
                            if (j == 0)
                            {
                                int temp = rotor[j];
                                rotor[j] = IncrementEndPoint((int)rotor[rotorSize]);
                                rotor[rotorSize] = IncrementEndPoint(temp);
                        }
                            else if(j < rotorSize)
                            {
                                rotor[j] = IncrementEndPoint((int)rotor[j + 1]);
                            }
                        }
                        catch (ArgumentOutOfRangeException e)
                        {

                        }

                    }
                }
            }

            private int IncrementEndPoint(int endPoint)
            {
                if (endPoint == rotorSize)
                    return 0;

                return endPoint++;
            }
    }
}
