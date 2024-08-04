using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw7_Sudoku_Archibald 
{
    class BoardFin
    {
        public string Solver(int[,] board)
        {
            int[,] solvedBoard = board;
            int[,] initialdBoard = board;
            List<int> FailedVals = new List<int>();
            bool pass = false;
            while (pass == false)
            {
               pass = Generation(ref solvedBoard, initialdBoard, 0, 0);
                //if(pass == true)
                //{
                //    FailedVals = TestAll( solvedBoard);
                //    if(FailedVals.Count() == 0)
                //    {
                //        pass = true;
                //    }
                //    else
                //    {
                //        pass = false;
                //    }
                //}
            }
            char[,] retVal = new char[9, 9];
            for(int i= 0; i<9; i++)
            {
                for (int j = 0; j<9; j++)
                {
                    retVal[i, j] = char.Parse(solvedBoard[i,j].ToString());
                }
            }
            return retVal.ToString();
        }
        //Recursively solves the board.
        bool Generation(ref int[,] board, int[,] inBoard, int col, int row)
        {
            List<int> TestVals = new List<int>
                {
                    1,2,3,4,5,6,7,8,9
                };            

            bool pass = false;

            if (inBoard[col, row] == 0)
            {
                //if ((TestVals.Count != 0) && (pass == false))
                //{
                    //while ((TestVals.Count != 0) && (pass == false))
                    //{
                    int temp = board[row, col];


                    if (IsAcceptable(board, col, row) == false)
                    {

                        if (((row + 1) != 9) || (col + 1 != 9))
                        {
                            if (row + 1 != 9)
                            {
                                pass = Generation(ref board, inBoard, col, row + 1);
                            }
                            else
                            {
                                if (col + 1 != 9)
                                {                                    
                                    pass = Generation(ref board, inBoard, col + 1, 0);
                                }
                            }
                        }
                        else
                        { pass = true; }

                    //}
                    //else
                    //{
                        bool exit = false;
                        while ((exit == false) && (TestVals.Count != 0))
                        {
                            while ((TestVals.Contains(temp) == false) && (TestVals.Count != 0))
                            {
                                board[col, row] = RandomNum(1, 9);
                                temp = board[col, row];

                            if(TestVals.Count == 1)
                            {
                                board[col, row] = TestVals[0];
                                temp = board[col, row] ;

                            }

                        }
                            TestVals.Remove(temp );
                            if (IsAcceptable(board, col, row) == true)
                            {
                                exit = true;
                            pass = true;
                            }
                        }
                    //}
                }
                if (pass == false)
                {
                    board[col, row] = 0;
                }
                //}
            }
            else
            {
                if (((row + 1) != 9) || (col + 1 != 9))
                {
                    if (row + 1 != 9)
                    {
                        pass = Generation(ref board, inBoard, col, row + 1);
                    }
                    else
                    {
                        if (col + 1 != 9)
                        {                            
                            pass = Generation(ref board, inBoard, col + 1, 0);
                        }
                    }
                }
                else
                { pass = true; }
            }
            return pass;
        }

        int RandomNum(int minval, int maxval)
        {
            Random rand = new Random();
            return rand.Next(minval, maxval);
        }

        //tests if individual values are acceptable
        bool IsAcceptable(int[,] board, int col, int row)
        {
            bool pass;
            
            //if ((col%3 == 2) && (row%3 == 2))
            //{
            //    box = TestBox(board, col, row);
            //}
            if ((TestRows(board, col, row) == true) && (TestCollumns(board, col, row) == true) && (TestBox(board, col, row) == true))
            {
                pass = true;
            }
            else
            {
                pass = false;
            }
            return pass;
        }

        bool TestRows(int[,] board, int col, int row)
        {
            bool pass = true;
            //for(int r = row; r< row+3; r++)
            //{
            List<int> TestValRow = new List<int>
                {
                    1,2,3,4,5,6,7,8,9
                };

            for (int r = 0; r < row; r++)
            {
                //if (board[col, r] != 0)
                //{
                    if (TestValRow.Contains(board[col, r]))
                    {
                        TestValRow.Remove(board[col, r]);
                    }
                    else
                    {
                        pass = false;
                        break;
                    }
                //}
            }
            //}
            return pass;
        }
        bool TestCollumns(int[,] board, int col, int row)
        {
            bool pass = true;
            //for (int c = col; c < col+3; c++)
            //{
            List<int> TestValCol = new List<int>
                {
                    1,2,3,4,5,6,7,8,9
                };

            for (int c = 0; c <= col; c++)
            {
                //if (board[c, row] != 0)
                //{
                    if (TestValCol.Contains(board[c, row]))
                    {
                        TestValCol.Remove(board[c, row]);
                    }
                    else
                    {
                        pass = false;
                        break;
                    }
                //}
            }
            //}
            return pass;
        }
        //Tests individual boxes for correct value
        bool TestBox(int[,] board, int coll, int rows)
        {
            int row = rows - rows % 3;
            int col = coll - coll % 3;
            bool pass = true;
            List<int> TestValBox = new List<int>
                {
                    1,2,3,4,5,6,7,8,9
                };

            for (int r = row; r <= rows; r++)
            {
                for (int c = col; c <= coll; c++)
                {
                    //if (board[c, r] != 0)
                    //{
                        if (TestValBox.Contains(board[c, r]))
                        {
                            TestValBox.Remove(board[c, r]);
                        }
                        else
                        {
                            pass = false;
                            break;
                        }
                    //}
                }
            }
            return pass;
        }

        //Tests entire board for correct input.
        public List<int> TestAll(int[,] board)
        {
            List<int> Return = new List<int>();            
            Return.AddRange(TestRows(board));
            Return.AddRange(TestCollumns(board));
            Return.AddRange(TestBoxes(board));            
            
            return Return;
        }
        //Checks rows for correct input.
        List<int> TestRows(int[,] val)
        {
            //bool failedVal = false;
            List<int> FailedVal = new List<int>();

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
                        //failedVal = true;
                        FailedVal.Add(i);
                        FailedVal.Add(j);
                    }
                }
            }
            return FailedVal;
        }

        //Tests collumns for correct input.
        List<int> TestCollumns(int[,] val)
        {
            //bool failedVal = false;
            List<int> FailedVal = new List<int>();

            for (int i = 0; i < 9; i++)
            {
                List<int> TestVals = new List<int>
                {
                    1,2,3,4,5,6,7,8,9
                };

                for (int j = 0; j < 9; j++)
                {
                    //if (val[j, i] != 0)
                    //{
                        if (TestVals.Contains(val[j, i]))
                        {
                            TestVals.Remove(val[j, i]);
                        }
                        else
                        {
                            //failedVal = true;
                            FailedVal.Add(j);
                            FailedVal.Add(i);
                        }
                    //}
                }
            }
            return FailedVal;
        }

        //Tests boxes for correct input.
        List<int> TestBoxes(int[,] val)
        {
            //bool failedVal = false;
            List<int> FailedVal = new List<int>();
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
                            if (val[(boxCol * 3) + c, r + (boxRow * 3)] != 0)
                            {
                                if (TestVals.Contains(val[(boxCol * 3) + c, r + (boxRow * 3)]))
                                {
                                    TestVals.Remove(val[(boxCol * 3) + c, r + (boxRow * 3)]);
                                }
                                else
                                {
                                    //failedVal = true;
                                    FailedVal.Add(boxCol + c);
                                    FailedVal.Add(boxRow + r);
                                }
                            }
                        }
                    }
                }
            }
            return FailedVal;
        }
    }
}
