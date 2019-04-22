using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw7_Sudoku_Archibald 
{
    class BoardFin
    {

        bool IsAcceptable(int[,] board, int col, int row)
        {
            bool pass;
            bool box = true;
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
                if (board[col, r] != 0)
                {
                    if (TestValRow.Contains(board[col, r]))
                    {
                        TestValRow.Remove(board[col, r]);
                    }
                    else
                    {
                        pass = false;
                        break;
                    }
                }
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
                if (board[c, row] != 0)
                {
                    if (TestValCol.Contains(board[c, row]))
                    {
                        TestValCol.Remove(board[c, row]);
                    }
                    else
                    {
                        pass = false;
                        break;
                    }
                }
            }
            //}
            return pass;
        }
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
                    if (board[c, r] != 0)
                    {
                        if (TestValBox.Contains(board[c, r]))
                        {
                            TestValBox.Remove(board[c, r]);
                        }
                        else
                        {
                            pass = false;
                            break;
                        }
                    }
                }
            }
            return pass;
        }

        public int[,] TestAll(int[,] board)
        {
            List<int> Return = new List<int>();            
            Return.AddRange(TestRows(board));
            Return.AddRange(TestCollumns(board));
            Return.AddRange(TestBoxes(board));
            int len = Return.Count() /2;

            int[,] ret = new int[len, len];
            for (int i = 0; i< len; i += 2)
            {
                for(int j = 0; j <2; j++)
                {
                    ret[i, j] = Return[i];
                }                 
            }
            return ret;
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
                    if (val[j, i] != 0)
                    {
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
                    }
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
