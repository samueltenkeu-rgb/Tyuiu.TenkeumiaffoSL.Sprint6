using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.TenkeumiaffoSL.Sprint6.Task1.V11.Lib;
using System;

namespace Tyuiu.TenkeumiaffoSL.Sprint6.Task1.V11.Test
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

            double[] wait = new double[11];

            for (int i = 0; i < 11; i++)
            {
                double x = -5 + i;
                double denominator = Math.Sin(x) + 3;

                if (Math.Abs(denominator) < 1e-10)
                {
                    wait[i] = 0;
                }
                else
                {
                    wait[i] = Math.Round(
                        (5 * x + 2.5) / denominator +
                        2 * x +
                        Math.Cos(x), 2);
                }
            }

            CollectionAssert.AreEqual(wait, result);
        }
    }
}
