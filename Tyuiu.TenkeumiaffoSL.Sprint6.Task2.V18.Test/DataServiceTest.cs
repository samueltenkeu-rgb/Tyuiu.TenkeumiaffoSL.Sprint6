using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.TenkeumiaffoSL.Sprint6.Task2.V18.Lib;
using System;

namespace Tyuiu.TenkeumiaffoSL.Sprint6.Task2.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            double[] result = ds.GetMassFunction(-5, 5);

            Assert.AreEqual(11, result.Length);

            double[] expected = new double[11];

            for (int i = 0; i < 11; i++)
            {
                double x = -5 + i;

                double denominator = 4 * x - 0.5;

                if (Math.Abs(denominator) < 1e-10)
                {
                    expected[i] = 0;
                }
                else
                {
                    expected[i] = Math.Round(
                        (3 * Math.Cos(x)) / denominator +
                        Math.Sin(x) -
                        5 * x -
                        2,
                        2
                    );
                }
            }

            CollectionAssert.AreEqual(expected, result);
        }
    }
}
