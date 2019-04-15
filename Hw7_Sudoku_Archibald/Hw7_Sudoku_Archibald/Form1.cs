using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hw7_Sudoku_Archibald
{
    public partial class Sudoku : Form
    {
        LoadBoard lb = new LoadBoard();
        List<char> Values = new List<char>();
        List<int> BoardNumbers = new List<int>();
        List<char> InputBoardValues = new List<char>();

        public Sudoku()
        {          

            InitializeComponent();

            //Loads Text boxes to a list.
            List<TextBox> inputBoxes = TxtBox();
            //Initializes the default load option via a radio buttion.
            radbtn_LoadEng.Checked = true;
            //Loads the values for the text boxes
            string board = lb.LoadBoards();
            FillBoxes(inputBoxes, board);
        }
               
        public void LoadTxtBoxes(List<TextBox> Boxes)
        {
            for(int i = 0; i <= Boxes.Count() - 1; i++)
            {
                Boxes[i].Text = "5";
                Boxes[i].Enabled = false;
                //Boxes[i].BackColor = Color.Gray;
            }
        }

        private void btn_NewGame_Click(object sender, EventArgs e)
        {
            LoadBoard lb = new LoadBoard();
            //Loads Text boxes to a list.
            List<TextBox> inputBoxes = TxtBox();
            string board;

            //Selects whether to generate a random board or load a pre-built one.
            if (radbtn_LoadEng.Checked == true)
            {
                board = lb.LoadBoards();
                ClearBoxes(inputBoxes);
                FillBoxes(inputBoxes, board);
            }
            else
            {
                if(radbtn_RandGen.Checked == true)
                {
                    ClearBoxes(inputBoxes);
                    board = lb.GenerateBoard();
                }
                else
                {
                    MessageBox.Show("An option must be checked.");
                }
            }
            
        }

        private void btn_Check_Click(object sender, EventArgs e)
        {
            List<TextBox> inputBoxes = TxtBox();
        }

        private void btn_Solve_Click(object sender, EventArgs e)
        {
            List<TextBox> inputBoxes = TxtBox();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            //Closes the form.
            Close();
        }

        //Initializes each text box to a list of text boxes and returns them in a function.
        public List<TextBox> TxtBox()
        {
            List<TextBox> inputBoxes = new List<TextBox>()
            {
                textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8, textBox9, textBox10, textBox11, textBox12, textBox13,
                textBox14, textBox15, textBox16, textBox17, textBox18, textBox19, textBox20, textBox21, textBox22, textBox23, textBox24, textBox25,
                textBox26, textBox27, textBox28, textBox29, textBox30, textBox31, textBox32, textBox33, textBox34, textBox35, textBox36, textBox37,
                textBox38, textBox39, textBox40, textBox41, textBox42, textBox43, textBox44, textBox45, textBox46, textBox47, textBox48, textBox49,
                textBox50, textBox51, textBox52, textBox53, textBox54, textBox55, textBox56, textBox57, textBox58, textBox59, textBox60, textBox61,
                textBox62, textBox63, textBox64, textBox65, textBox66, textBox67, textBox68, textBox69, textBox70, textBox71, textBox72, textBox73,
                textBox74, textBox75, textBox76, textBox77, textBox78, textBox79,textBox80, textBox81
            };
            return inputBoxes;
        }

        //Fills the required boxes with values
        void FillBoxes(List<TextBox> Boxes, string inBoard)
        {            
            //Sets a character array to the input string
            char[] inputNumber = inBoard.ToCharArray(); ;
            //Loops and inputs each number in the string to a text box.
            //This also locks the text boxes that have numbers as starting values.
            for(int i = 0; i < 81; i++)
            {
                if (inputNumber[i] != '.')
                {
                    Boxes[i].Text = inputNumber[i].ToString();
                    Boxes[i].Enabled = false;
                }
            }
        }

        //Resets and enables all text boxes.
        void ClearBoxes(List<TextBox> Boxes)
        {
            for(int i = 0; i< Boxes.Count; i++)
            {
                Boxes[i].Text = null;
                Boxes[i].Enabled = true;
            }
        }


    }
}
