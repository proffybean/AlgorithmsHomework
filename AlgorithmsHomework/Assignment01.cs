using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace AlgorithmsHomework
{
    [TestClass]
    public class Assignment01
    {
        [TestMethod]
        public void Problem1()
        {
            double[] prices = new double[] { 12.30, 33.01, 101.50, 78.00, 31.0, 5.78, 21.18 };

            double min = prices[0];
            double max = prices[0];

            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] > max)
                    max = prices[i];

                if (prices[i] < min)
                    min = prices[i];
            }

            Assert.IsTrue(true);
        }

        [TestMethod]
        public void Problem2()
        {
            int[] A = { 4, 8, 9, 2, 13, 6, 8, 21};
            int length = A.Length;
            int sum;

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (i == j) continue;
                    sum = A[i] + A[j];

                    for (int k = 0; k < length; k++)
                    {
                        if (A[k] == sum)
                        {
                            WriteLine(A[i] + " " + A[j]);
                        }
                    }
                }
            }
        }

    }
}
