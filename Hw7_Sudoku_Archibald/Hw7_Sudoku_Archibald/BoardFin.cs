using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw7_Sudoku_Archibald
{
    class BoardFin
    {        
        
        public List<int> TestRows(int[,] val, ref List<int> failed)
        {
            List<int> failedVal = new List<int>();
            for (int i = 0; i < 9; i++)
            {
                List<int> TestVals = new List<int>
                {
                    1,2,3,4,5,6,7,8,9
                };

                for (int j= 0; j<9; j++)
                {
                    if (TestVals.Any(x => x == val[i,j])) {
                        TestVals.RemoveAt(val[i, j] - 1);
                    }
                    else
                    {
                        failedVal.Add((i*9) + j);
                    }
                }
            }
            return failedVal;
        }

        public List<int> TestCollumns(int[,] val)
        {
            List<int> failedVal = new List<int>();

            for (int i = 0; i < 9; i++)
            {
                List<int> TestVals = new List<int>
                {
                    1,2,3,4,5,6,7,8,9
                };

                for (int j = 0; j < 9; j++)
                {
                    if (TestVals.Any(x => x == val[j, i]))
                    {
                        TestVals.RemoveAt(val[j, i] - 1);
                    }
                    else
                    {
                        failedVal.Add((j * 9) + i);
                    }
                }                
            }
            return failedVal;
        }

        public void TestBoxes()
        {

        }
    }
}
