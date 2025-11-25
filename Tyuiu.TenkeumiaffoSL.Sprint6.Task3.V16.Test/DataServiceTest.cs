using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.TenkeumiaffoSL.Sprint6.Task3.V16.Lib;

namespace Tyuiu.TenkeumiaffoSL.Sprint6.Task3.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[5, 5] {
                { 14, 1, -3, 1, 10 },
                { 7, -3, 5, -4, 0 },
                { -10, -19, -18, -9, 19 },
                { -2, -2, -16, 2, -17 },
                { -16, 9, 5, -10, 16 }
            };

            int[,] result = ds.Calculate(matrix);

            // Проверка третьей строки
            Assert.AreEqual(0, result[2, 0]); // -10 → 0
            Assert.AreEqual(-19, result[2, 1]);
            Assert.AreEqual(0, result[2, 2]);  // -18 → 0
            Assert.AreEqual(-9, result[2, 3]);
            Assert.AreEqual(19, result[2, 4]);

            // Остальные строки не должны измениться
            Assert.AreEqual(14, result[0, 0]);
            Assert.AreEqual(7, result[1, 0]);
            Assert.AreEqual(-2, result[3, 0]);
            Assert.AreEqual(-16, result[4, 0]);
        }
    }
}
