using System;

namespace Solution
{
    /// <summary>
    /// An Arithematic Progression of numbers has a missing number, find that missing number.
    /// For eg: if there are 5 numbers - 1 3 5 9 11 find the missing number which is 7 in this case.
    /// </summary>
    public class Solution
    {
        public static void Main(string[] args)
        {
            
            string line1 = Console.ReadLine();
            
            string line2 =  Console.ReadLine();

            Solution1 solution = new Solution1(line1, StringToIntArray(line2,' '));
            int stdout = solution.Calculate();

            Console.WriteLine(stdout);                      
        }

        private static int[] StringToIntArray(string value, char sep)
        {
            string[] sa = value.Split(sep);
            int[] ia = new int[sa.Length];

            for (int i = 0; i < ia.Length; ++i)
            {
                string s = sa[i];

                int j;

                if (int.TryParse(s, out j))
                {
                    ia[i] = j;
                }
            }
            return ia;
        }

    }
}
