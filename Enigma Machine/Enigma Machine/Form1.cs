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
        string outVal = null;
        int[] EaRotors = new int[3];
        int[] NumRotations = new int[3] { 0,0,0};
        LtSeq lt = new LtSeq();
        MidSeq mid = new MidSeq();
        RtSeq rt = new RtSeq();
        Reflection rf = new Reflection();
        List<int> NumInput = new List<int>();

        //List<int> LtPosition = new List<int>()
        //{
        //    0,0,0,0
        //};
        //List<int> MidPosition = new List<int>()
        //{
        //    0,0,0,0
        //};
        //List<int> RtPosition = new List<int>()
        //{
        //    0,0,0,0
        //};


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
            //char[] numbers = inVal.ToCharArray();
            char number = inVal.LastOrDefault();            
                
            NumInput.Add(int.Parse(number.ToString()));
            //new int[numbers.Length];
            //for (int i = 0; i < numbers.Count(); i++)
            //{
            //   NumInput.Add( int.Parse(numbers[i].ToString()));
            //}
            //for(int j = 0; j < numbers.Count(); j++)                
            //{
            if (NumInput.Count != 0)
            {
                int j = NumInput.Count - 1;           

                    int temp = NumInput[j];
                    //temp = lt.ScrambleSequenceFwd(EaRotors[0], NumInput[j]);
                    temp = lt.ScrambleSequenceFwd(EaRotors[0], temp);
                    temp = mid.ScrambleSequenceFwd(EaRotors[1], temp);
                    temp = rt.ScrambleSequenceFwd(EaRotors[2], temp);

                    temp = rf.Reflect(temp);

                    temp = rt.ScrambleSequenceRev(EaRotors[2], temp);
                    temp = mid.ScrambleSequenceRev(EaRotors[1], temp);
                    temp = lt.ScrambleSequenceRev(EaRotors[0], temp);

                    IncrementRotors();

                    NumInput[j] = temp;
                    //outVal += Convert.ToString(NumInput[j]);
            }
            else { int j = 0; }
            //}

            textBox2.Text = NumInput.ToString();//NumInput.ToString();
                ///ResetRotors();
         
            }
                

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

        void ResetRotors()
        {
            lt.RotateRotors(EaRotors[0], NumRotations[0], true);
            mid.RotateRotors(EaRotors[1], NumRotations[1], true);
            rt.RotateRotors(EaRotors[2], NumRotations[2], true);
        }

        //bool[,] CheckBoxes()
        //{
        //    bool[,] ChkBoxRotors = new bool[3, 4];

        //    RadioButton[,] Boxes = new RadioButton[,]
        //    {
        //        { radbtn_Lt1, radbtn_Lt2, radbtn_Lt3, radbtn_Lt4},
        //        { radbtn_Mid1, radbtn_Mid2, radbtn_Mid3, radbtn_Mid4},
        //        { radbtn_Rt1, radbtn_Rt2, radbtn_Rt3, radbtn_Rt4}
        //    };

        //    for(int i = 0; i <3; i++)
        //    {
        //        for(int j = 0; j<4; j++)
        //        {
        //            ChkBoxRotors[i, j] = Boxes[i, j].Checked;
        //        }
        //    }

        //    return ChkBoxRotors;
        //}

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

        private void textBox1_Leave(object sender, EventArgs e)
        {
            ResetRotors();
            outVal = null;
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
