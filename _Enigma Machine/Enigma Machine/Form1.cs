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
using static System.Net.Mime.MediaTypeNames;

namespace Enigma_Machine
{
    public partial class Form1 : Form
    {        
        private int[] NumRotations = new int[4] { 0,0,0,0};
        private ReelSequence Reel = new ReelSequence();
        private LetterMap characterMap = new LetterMap();
        private int characterCounter;
        private string outputText = "";


        public Form1()
        {
            InitializeComponent();
        }

        //event methods
        private void txt_Input_TextChanged(object sender, EventArgs e)
        {
            
            string inVal = txt_Input.Text.ToLower();
            int stringLength = inVal.Length;
            
            if((stringLength-characterCounter) == 1)
            {
                outputText += encodeOne(inVal[stringLength-1]);
                characterCounter = inVal.Count();
            }
            else if (stringLength > characterCounter+1)
            {
                characterCounter = inVal.Count();
                outputText = encodeMany(inVal);
            }
            else if(stringLength < characterCounter)
            {
                int difference = stringLength - characterCounter;
                for(int i = 0; i < difference; i++)
                {
                    Reel.DecrementRotors();
                }
                characterCounter = stringLength;
            }
            txt_output.Text = outputText;
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

        //Resets the text box and incrementations upon leaving.
        private void button1_Click(object sender, EventArgs e)
        {
            Reel = new ReelSequence();
            outputText = "";
        }


        //Support Methods
        //encode/translate text
        private String encodeMany(string text)
        {
            List<char> Input = text.ToList();
            //Stack<char> chars = new Stack<char>();
            string charOutput = "";

            if (Input.Count != 0)
            {
                foreach (char c in Input)
                {
                    int transformNumber = characterMap.mapToNumber(System.Char.ToLower(c));
                    transformNumber = Reel.ScrambleSequenceFwd(transformNumber);
                    charOutput += characterMap.mapToChar(transformNumber);
                }
            }

            return charOutput.ToUpper();
        }

        private String encodeOne(char text)
        {
            int transformNumber = characterMap.mapToNumber(System.Char.ToLower(text));
            transformNumber = Reel.ScrambleSequenceFwd(transformNumber);
            string charOutput = characterMap.mapToChar(transformNumber);

            return charOutput.ToUpper();
        }
    }
}
