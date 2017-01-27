using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace AlgorithmsHomework
{
    [TestClass]
    public class Assignment01
    {
        [TestMethod]
        public void MyTestMethod()
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

        public void firsttest()
        {

        }

    }
}
