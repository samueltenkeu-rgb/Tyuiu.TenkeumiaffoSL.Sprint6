using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.TenkeumiaffoSL.Sprint6.Task4.V22.Lib;

namespace Tyuiu.TenkeumiaffoSL.Sprint6.Task4.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CorrectMassFunction()
        {
            DataService ds = new DataService();
            double[] res = ds.GetMassFunction(-5, 5);

            Assert.AreEqual(11, res.Length);

            double expected = Math.Round(Math.Sin(0) + Math.Cos(0) / 2 - 1.5 * 0, 2);
            Assert.AreEqual(expected, res[5]);
        }
    }
}
