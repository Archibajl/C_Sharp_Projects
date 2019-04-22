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
        BoardFin fn = new BoardFin();
        List<char> Values = new List<char>();
        List<int> BoardNumbers = new List<int>();
        List<char> FailedBoardValues = new List<char>();

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
            {   //Tests for randomly generated board selection.
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
            //Initializes text boxes to a list.
            List<TextBox> inputBoxes = TxtBox();
            int[,] boardVal = new int[9,9];
            bool testVal = true;
            int boxNum = 0;

            for(int i=0; i < 9; i++)
            {
                for(int j=0; j < 9; j++)
                {
                    if (!int.TryParse(inputBoxes[boxNum].Text.ToString(), out boardVal[i, j]))
                    {
                        testVal = false;
                        inputBoxes[boxNum].BackColor = Color.LightYellow;
                    }
                    boxNum++;
                }
            }
            //If all values are numbers a function is called to check the boardfor correct values.
            if(testVal == true)
            {
                bool Rows, Collumns, Boxes;
                List<Task<bool>> TaskList = new List<Task<bool>>();
                Rows =  TestRows(boardVal, inputBoxes);
                Collumns = TestCollumns(boardVal, inputBoxes);
                Boxes = TestBoxes(boardVal, inputBoxes);

                if (Rows == false && Collumns == false && Boxes == false)
                {

                    GreenBoxes(inputBoxes);
                }
            }

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
                    //Boxes[i].Enabled = false;
                }
            }
        }

        //Checks rows for correct input.
        bool TestRows(int[,] val, List<TextBox> Boxes)
        {
            bool failedVal = false;
            for (int i = 0; i < 9; i++)
            {
                List<int> TestVals = new List<int>
                {
                    1,2,3,4,5,6,7,8,9
                };

                for (int j = 0; j < 9; j++)
                {
                    if (TestVals.Contains(val[i, j]))
                    {
                        TestVals.Remove(val[i, j]);
                    }
                    else
                    {
                        failedVal = true;
                        RowLineOut((i * 9) + j, Boxes);
                    }
                }
            }
            return failedVal;
        }

        //Tests collumns for correct input.
        bool TestCollumns(int[,] val, List<TextBox> Boxes)
        {
           bool failedVal = false;

            for (int i = 0; i < 9; i++)
            {
                List<int> TestVals = new List<int>
                {
                    1,2,3,4,5,6,7,8,9
                };

                for (int j = 0; j < 9; j++)
                {
                    if (val[j, i] != 0)
                    {
                        if (TestVals.Contains(val[j, i]))
                        {
                            TestVals.Remove(val[j, i]);
                        }
                        else
                        {
                            failedVal = true;
                            CollumnLineOut((j * 9) + i, Boxes);
                        }
                    }
                }
            }
            return failedVal;
        }

        //Tests boxes for correct input.
        bool TestBoxes(int[,] val, List<TextBox> inputBoxes)
        {
            bool failedVal = false;
            for (int boxCol = 0; boxCol < 3; boxCol++)
            {
                for (int boxRow = 0; boxRow < 3; boxRow++)
                {
                    List<int> TestVals = new List<int>
                {
                    1,2,3,4,5,6,7,8,9
                };
                    for (int r = 0; r < 3; r++)
                    {
                        for (int c = 0; c < 3; c++)
                        {
                            if (val[(boxCol*3) + c, r + (boxRow*3)] != 0)
                            {
                                if (TestVals.Contains( val[(boxCol * 3) + c, r + (boxRow * 3)]))
                                {
                                    TestVals.Remove(val[(boxCol * 3) + c, r + (boxRow * 3)]);
                                }
                                else
                                {
                                    failedVal = true;
                                    BoxLineOut((((boxCol*3) + c)) , ((boxRow*3) + r), inputBoxes);
                                }
                            }
                        }
                    }
                }
            }
            return failedVal;
        }

        //Changes the color of the Collumn for failed values.
        void CollumnLineOut(int locator, List<TextBox> inputBoxes)
        {            
            int startPoint;             
            inputBoxes[locator].BackColor = Color.Red;
            if ((locator) < 9 )
            {
                startPoint = locator;
            }
            else
            {
                startPoint = locator;
                while((startPoint) >= 9 )
                {
                    startPoint -= 9;
                }
            }
            for(int i = 0; i<9; i ++)
            {
                inputBoxes[startPoint + (i*9)].BackColor = Color.IndianRed ;
            }
        }

        //Changes the color of the failed row.
        void RowLineOut(int locator, List<TextBox> inputBoxes)
        {
            int startPoint = locator;
            if (startPoint %9 != 0)
            {
                //Sets the box to the starting text box of the line.
                while(startPoint %9 != 0)
                {
                    startPoint -= 1;
                }
            }
            for(int i = 0; i<9; i++)
            {
                inputBoxes[startPoint + i].BackColor = Color.IndianRed;
            }
        }

        //Changes the color of the sections of boxes that fail the check.
        void BoxLineOut(int locatorA, int LocatorB, List<TextBox> inputBoxes)
        {
            //Setting the start point to the 1D array of text boxes
            int startPoint = (((locatorA-locatorA%3)*9)+(LocatorB- LocatorB%3));
            for (int r = startPoint; r <= 18+startPoint; r += 9)
            {
                for (int i = 0; i < 3; i++)
                {
                    inputBoxes[ r + i].BackColor = Color.PaleVioletRed;
                }
            }
        }

        //Resets and enables all text boxes.
        void ClearBoxes(List<TextBox> Boxes)
        {
            for(int i = 0; i< Boxes.Count; i++)
            {
                Boxes[i].Text = null;
                Boxes[i].BackColor = Color.White;
                Boxes[i].Enabled = true;
            }
        }
        void GreenBoxes(List<TextBox> Boxes)
        {
            for (int i = 0; i < Boxes.Count; i++)
            {
                Boxes[i].BackColor = Color.GreenYellow;
                Boxes[i].Enabled = false;
            }
        }
    }
}
