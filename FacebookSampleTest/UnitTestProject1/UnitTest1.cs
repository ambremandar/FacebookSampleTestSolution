using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var N = "10000000";
            //var numbers = "1 3 5 9 11";

            var n1 = Int32.Parse(N);
            var start = 1;
            var space = 2;
            var skip = 9900000;
            var expectedOutput = 0;
            var n1a = new int[n1];

            n1a[0] = start;

            for (int i = 1; i < (n1a.Length - 1); i++)
            {
                if (i == skip)
                {
                    expectedOutput = n1a[i - 1] + space;
                    n1a[i] = n1a[i-1] + space + space;
                }
                else
                    n1a[i] = n1a[i-1] + space;
            }

            //var numbers = string.Empty;
            //for (int j = 0; j < (n1a.Length - 1); j++)
            //{
            //    numbers += n1a[j].ToString() + " ";
            //}

            Solution.Solution1 solution = new Solution.Solution1(N, n1a);
            var stdout = solution.Calculate();

            Assert.AreEqual(expectedOutput, stdout,expectedOutput.ToString());
        }
    }
}
