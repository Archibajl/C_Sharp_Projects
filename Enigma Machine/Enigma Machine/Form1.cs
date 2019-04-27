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
        bool[,] EaRotors = new bool[3, 4];

        List<int> LtPosition = new List<int>()
        {
            0,0,0,0
        };
        List<int> MidPosition = new List<int>()
        {
            0,0,0,0
        };
        List<int> RtPosition = new List<int>()
        {
            0,0,0,0
        };
        

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string inVal = textBox1.Text;
            char[] numbers = inVal.ToCharArray();
            int[] numInput = Array.ConvertAll(numbers, int.Parse); ()//new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                int.TryParse(numbers[i], out numInput[i]);   
            }

            
        }

        private void chk_LtRotor1_CheckedChanged(object sender, EventArgs e)
        {
            EaRotors = CheckBoxes();
        }

        private void chk_LtRotor2_CheckedChanged(object sender, EventArgs e)
        {
            EaRotors = CheckBoxes();
        }

        private void chk_LtRotor3_CheckedChanged(object sender, EventArgs e)
        {
            EaRotors = CheckBoxes();
        }

        private void chk_LtRotor4_CheckedChanged(object sender, EventArgs e)
        {
            EaRotors = CheckBoxes();
        }

        private void chk_MidRotor1_CheckedChanged(object sender, EventArgs e)
        {
            EaRotors = CheckBoxes();
        }

        private void chk_MidRotor2_CheckedChanged(object sender, EventArgs e)
        {
            EaRotors = CheckBoxes();
        }

        private void chk_MidRotor3_CheckedChanged(object sender, EventArgs e)
        {
            EaRotors = CheckBoxes();
        }

        private void chk_MidRotor4_CheckedChanged(object sender, EventArgs e)
        {
            EaRotors = CheckBoxes();
        }

        private void chk_RtRotor1_CheckedChanged(object sender, EventArgs e)
        {
            EaRotors = CheckBoxes();
        }

        private void chk_RtRotor2_CheckedChanged(object sender, EventArgs e)
        {
            EaRotors = CheckBoxes();
        }

        private void chk_RtRotor3_CheckedChanged(object sender, EventArgs e)
        {
            EaRotors = CheckBoxes();
        }

        private void chk_RtRotor4_CheckedChanged(object sender, EventArgs e)
        {
            EaRotors = CheckBoxes();
        }

        bool[,] CheckBoxes()
        {
            bool[,] ChkBoxRotors = new bool[3, 4];

            CheckBox[,] Boxes = new CheckBox[,]
            {
                { chk_LtRotor1, chk_LtRotor2, chk_LtRotor3, chk_LtRotor4},
                { chk_MidRotor1, chk_MidRotor2, chk_MidRotor3, chk_MidRotor4},
                { chk_RtRotor1, chk_RtRotor2, chk_RtRotor3, chk_RtRotor4}
            };

            for(int i = 0; i <3; i++)
            {
                for(int j = 0; j<4; j++)
                {
                    ChkBoxRotors[i, j] = Boxes[i, j].Checked;
                }
            }

            return ChkBoxRotors;
        }

    }
}
