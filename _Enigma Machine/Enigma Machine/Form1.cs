//Justin Archibald
//CSC 3020
//Enigma machine Extera Credit.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enigma_Machine
{
    public partial class Form1 : Form
    {        
        private int[] EaRotors = new int[3];
        private int[] NumRotations = new int[4] { 0,0,0,0};
        private ReelSequence Reel = new ReelSequence();
        private LetterMap characterMap = new LetterMap();
        private Reflection reflector = new Reflection();
        private List<int> numInput = new List<int>();
        private List<char> charOutput = new List<char>();

        public Form1()
        {
            InitializeComponent();
            EaRotors[0] = 1;
            EaRotors[1] = 2;
            EaRotors[2] = 3;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string inVal = textBox1.Text;
            List<char> Input =inVal.ToList();
            char text = System.Char.ToLower(inVal.LastOrDefault());
            if (Input.Count() > numInput.Count())
            {
                numInput.Add(characterMap.mapToNumber(text));
                if (numInput.Count != 0)
                {
                    int j = numInput.Count - 1;

                    int temp = numInput[j];
                    //Runs the number generator forward and then in reverse to return the correct result.
                    numInput[j] = Reel.ScrambleSequenceFwd(temp);

                    //Returns the encoded value to the end of the list.
                    charOutput.Add(characterMap.mapToChar(numInput[j]));
                }
            }
            else if(Input.Count() < numInput.Count())
            {
                int difference = numInput.Count() - Input.Count();
                for(int i = 0; i < difference; i++)
                {
                    Reel.DecrementRotors();
                    numInput.RemoveAt(numInput.Count - 1);
                }
            }
            textBox2.Text = String.Concat(charOutput).ToUpper();
        }

        //Resets the rotors to their initial input values.
        private void ResetRotors()
        {
            Reel = new ReelSequence();
        }
        
       
        //Resets the text box and incrementations upon leaving.
        private void textBox1_Leave(object sender, EventArgs e)
        {
            ResetRotors();            
            textBox1.Text = "";
            textBox2.Text = "";
        }

        //Changes the number of starting rotations and resets the rotor
        private void txt_Reel1_TextChanged(object sender, EventArgs e)
        {
            string rotate = txt_Reel1.Text;
            if (int.TryParse(rotate, out NumRotations[0]))
            { }
            else { MessageBox.Show("Entry must be numeric."); }
        }

        private void txt_Reel2_TextChanged(object sender, EventArgs e)
        {
            string rotate = txt_Reel2.Text;
            if (int.TryParse(rotate, out NumRotations[1]))
            { }
            else { MessageBox.Show("Entry must be numeric."); }
        }

        private void txt_Reel3_TextChanged(object sender, EventArgs e)
        {
            string rotate = txt_Reel3.Text;
            if (int.TryParse(rotate, out NumRotations[2]))
            { }
            else { MessageBox.Show("Entry must be numeric."); }
        }
        private void txt_Reel4_TextChanged(object sender, EventArgs e)
        {
            string rotations = txt_Reel4.Text;
            if (int.TryParse(rotations, out NumRotations[3]))
            {

            }
            else { MessageBox.Show("Entry must be numeric."); }
        }


        private void btn_setReels_Click(object sender, EventArgs e)
        {
            for(int i=0; i<NumRotations.Length; i++)
            {
                Reel.IncrementRotors(i, NumRotations[i]);
            }
        }
    }
}
