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
        int[] EaRotors = new int[3];
        int[] NumRotations = new int[3] { 0,0,0};
        LtSeq lt = new LtSeq();
        MidSeq mid = new MidSeq();
        RtSeq rt = new RtSeq();
        Reflection rf = new Reflection();
        List<int> NumInput = new List<int>();

        public Form1()
        {
            InitializeComponent();
            radbtn_Lt1.Checked = true;
            EaRotors[0] = 1;
            radbtn_Mid2.Checked = true;
            EaRotors[1] = 2;
            radbtn_Rt3.Checked = true;
            EaRotors[2] = 3;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string inVal = textBox1.Text;
            List<char> Input =inVal.ToList();
            char number = inVal.LastOrDefault();
            if (Input.Count() > NumInput.Count())
            {
                NumInput.Add(int.Parse(number.ToString()));
                
                if (NumInput.Count != 0)
                {
                    int j = NumInput.Count - 1;

                    int temp = NumInput[j];
                    //Runs the number generator forward and then in reverse to return the correct result.
                    temp = lt.ScrambleSequenceFwd(EaRotors[0], temp);
                    temp = mid.ScrambleSequenceFwd(EaRotors[1], temp);
                    temp = rt.ScrambleSequenceFwd(EaRotors[2], temp);

                    temp = rf.Reflect(temp);

                    temp = rt.ScrambleSequenceRev(EaRotors[2], temp);
                    temp = mid.ScrambleSequenceRev(EaRotors[1], temp);
                    temp = lt.ScrambleSequenceRev(EaRotors[0], temp);
                    //Increments the position of the rotors.
                    IncrementRotors();
                    //Returns the encoded value to the end of the list.
                    NumInput[j] = temp;                    
                }
                else { int j = 0; }
                //}
            }
            else
            {
                int difference = NumInput.Count() - Input.Count();
                for(int i = 0; i < difference; i++)
                {
                    DecrementRotors();
                    NumInput.RemoveAt(NumInput.Count - 1);
                }
            }
            textBox2.Text = string.Join("", NumInput);
        }
                
        //Decrements the rotors 
        void DecrementRotors()
        {
            if (rt.RotationCounter > 0)
            {
                rt.DecrementRotors(EaRotors[2], 1, false);
            }
            else
            {
                if (mid.RotationCounter > 0)
                {
                    rt.RotationCounter = 9;
                    rt.DecrementRotors(EaRotors[2], 1, false);
                    mid.DecrementRotors(EaRotors[1], 1, false);
                }
                else
                {
                    rt.RotationCounter = 9;
                    mid.RotationCounter = 9;
                    rt.DecrementRotors(EaRotors[2], 1, false);
                    mid.DecrementRotors(EaRotors[1], 1, false);
                    lt.DecrementRotors(EaRotors[0], 1, false);
                }
            }
        }

        //Increments each sections rotors.
        void IncrementRotors()
        {
            if(rt.RotationCounter < 10)
            {
                rt.RotateRotors(EaRotors[2], 1, false);
            }
            else
            {
                if(mid.RotationCounter < 10)
                {
                    rt.RotationCounter = 0;
                    rt.RotateRotors(EaRotors[2], 1, false);
                    mid.RotateRotors(EaRotors[1], 1, false);                    
                }
                else
                {
                    rt.RotationCounter = 0;
                    mid.RotationCounter = 0;
                    rt.RotateRotors(EaRotors[2], 1, false);
                    mid.RotateRotors(EaRotors[1], 1, false);
                    lt.RotateRotors(EaRotors[0], 1, false);
                }
            }
        }

        //Resets the rotors to their initial input values.
        void ResetRotors()
        {
            lt.RotateRotors(EaRotors[0], NumRotations[0], true);
            mid.RotateRotors(EaRotors[1], NumRotations[1], true);
            rt.RotateRotors(EaRotors[2], NumRotations[2], true);
        }
        
        //Changes the saved values and number of rotations in each position.
        private void radbtn_Lt1_CheckedChanged(object sender, EventArgs e)
        {
            if (radbtn_Lt1.Checked)
            {
                EaRotors[0] = 1;
                lt.RotateRotors(EaRotors[0], NumRotations[0], true);
            }
        }

        private void radbtn_Lt2_CheckedChanged(object sender, EventArgs e)
        {
            if (radbtn_Lt2.Checked)
            {
                EaRotors[0] = 2;
                lt.RotateRotors(EaRotors[0], NumRotations[0], true);
            }
        }

        private void radbtn_Lt3_CheckedChanged(object sender, EventArgs e)
        {
            if (radbtn_Lt3.Checked)
            {
                EaRotors[0] = 3;
                lt.RotateRotors(EaRotors[0], NumRotations[0], true);
            }
        }

        private void radbtn_Lt4_CheckedChanged(object sender, EventArgs e)
        {
            if (radbtn_Lt4.Checked)
            {
                EaRotors[0] = 4;
                lt.RotateRotors(EaRotors[0], NumRotations[0], true);
            }
        }

        private void radbtn_Mid1_CheckedChanged(object sender, EventArgs e)
        {
            if (radbtn_Mid1.Checked)
            {
                EaRotors[1] = 1;
                mid.RotateRotors(EaRotors[1], NumRotations[1], true);
            }
        }

        private void radbtn_Mid2_CheckedChanged(object sender, EventArgs e)
        {
            if (radbtn_Mid2.Checked)
            {
                EaRotors[1] = 2;
                mid.RotateRotors(EaRotors[1], NumRotations[1], true);
            }
        }

        private void radbtn_Mid3_CheckedChanged(object sender, EventArgs e)
        {
            if (radbtn_Mid3.Checked)
            {
                EaRotors[1] = 3;
                mid.RotateRotors(EaRotors[1], NumRotations[1], true);
            }
        }

        private void radbtn_Mid4_CheckedChanged(object sender, EventArgs e)
        {
            if (radbtn_Mid4.Checked)
            {
                EaRotors[1] = 4;
                mid.RotateRotors(EaRotors[1], NumRotations[1], true);
            }
        }

        private void radbtn_Rt1_CheckedChanged(object sender, EventArgs e)
        {
            if (radbtn_Rt1.Checked)
            {
                EaRotors[2] = 1;
                rt.RotateRotors(EaRotors[2], NumRotations[2], true);
            }
        }

        private void radbtn_Rt2_CheckedChanged(object sender, EventArgs e)
        {
            if (radbtn_Rt2.Checked)
            {
                EaRotors[2] = 2;
                rt.RotateRotors(EaRotors[2], NumRotations[2], true);
            }
        }

        private void radbtn_Rt3_CheckedChanged(object sender, EventArgs e)
        {
            if (radbtn_Rt3.Checked)
            {
                EaRotors[2] = 3;
                rt.RotateRotors(EaRotors[2], NumRotations[2], true);
            }
        }

        private void radbtn_Rt4_CheckedChanged(object sender, EventArgs e)
        {
            if (radbtn_Rt4.Checked)
            {
                EaRotors[2] = 4;
                rt.RotateRotors(EaRotors[2], NumRotations[2], true);
            }
        }

        //Changes the number of starting rotations and resets the rotor
        private void txt_StartPos1_TextChanged(object sender, EventArgs e)
        {            
                string rotate = txt_StartPos1.Text;
            if (   int.TryParse(rotate, out NumRotations[0]))
            {
                lt.RotateRotors(EaRotors[0], NumRotations[0], true);
            }
            else{ MessageBox.Show("Entry must be numeric."); }
        }

        private void txt_StartPos2_TextChanged(object sender, EventArgs e)
        {
            string rotate = txt_StartPos2.Text;
            if (int.TryParse(rotate, out NumRotations[1]))
            {
                mid.RotateRotors(EaRotors[1], NumRotations[1], true);
            }
            else { MessageBox.Show("Entry must be numeric."); }
        }

        private void txt_StartPos3_TextChanged(object sender, EventArgs e)
        {
            string rotate = txt_StartPos3.Text;
            if (int.TryParse(rotate, out NumRotations[2]))
            {
                rt.RotateRotors(EaRotors[2], NumRotations[2], true);
            }
            else { MessageBox.Show("Entry must be numeric."); }
        }

        //Resets the text box and incrementations upon leaving.
        private void textBox1_Leave(object sender, EventArgs e)
        {
            ResetRotors();            
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
