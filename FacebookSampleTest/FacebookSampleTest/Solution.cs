using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    public class Solution1
    {
        string line1;
        string line2;
        int[] numArr;
        public Solution1(string value1, int[] value2)
        {
            this.line1 = value1;
            //this.line2 = value2.Trim();
            this.numArr = value2;
        }

        public int Calculate()
        {           
            int N;
            bool parse = Int32.TryParse(line1, out N);
            
            char c = ' ';

           // int[] numArr = StringToIntArray(line2, c);

            int space = 0;

            int STDOUT = 0;

            if ((numArr[1] - numArr[0]) == (numArr[2] - numArr[1]))
            {
                space = numArr[1] - numArr[0];
            }
            else if ((numArr[3] - numArr[2]) == (numArr[2] - numArr[1]))
            {
                space = numArr[2] - numArr[1];
            }
            else if ((numArr[3] - numArr[2]) == (numArr[1] - numArr[0]))
            {
                space = numArr[1] - numArr[0];
            }

            for (int i = 0; i < (N - 1); i++)
            {
                if ((numArr[i + 1] - numArr[i]) != space)
                {
                    STDOUT = numArr[i + 1] - space;
                    break;
                }
            }

            return STDOUT;
                      
        }

        
    }
}
