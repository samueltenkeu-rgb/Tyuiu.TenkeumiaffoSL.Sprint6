using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.TenkeumiaffoSL.Sprint6.Task0.V16.Lib;

namespace Tyuiu.TenkeumiaffoSL.Sprint6.Task0.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double result = ds.Calculate(3);

            double wait = (1 + Math.Pow(3, 3)) / (3 * 3);
            wait = Math.Round(wait, 3);

            Assert.AreEqual(wait, result);
        }
    }
}
