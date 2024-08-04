using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma_Machine
{
    internal class ReelOriginator : IMomento
    {
        private int rotationCounter = 0;
        private int reelSize = 9;
        //Reel is a set of rotors each set to a predefined state
        //Contains Rotors 1, 2, 3, and 4
        protected List<List<int>> reel;

        protected Stack<List<List<int>>> state;


        public int RotationCounter
        {
            get { return rotationCounter; }
            set { rotationCounter = value; }
        }

        public bool getState()
        {
            if((state == null) || (state.Count >0))
                    return false;

            reel = state.Pop();
            return true;
        }

        public bool setState()
        {
            try {
                state.Push(
                    reel
                    );
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
