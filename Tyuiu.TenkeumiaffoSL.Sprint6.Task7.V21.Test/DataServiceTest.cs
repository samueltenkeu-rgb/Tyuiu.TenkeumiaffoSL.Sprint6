using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.TenkeumiaffoSL.Sprint6.Task7.V21.Lib;

namespace Tyuiu.TenkeumiaffoSL.Sprint6.Task7.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        private string testFilePath = "TestMatrix.csv";

        [TestInitialize]
        public void Setup()
        {
            File.WriteAllLines(testFilePath, new string[]
            {
                "1;2;3;4;5;6;7;5;9",
                "2;3;4;5;6;7;8;3;1",
                "9;8;7;6;5;4;3;5;0",
                "0;1;2;3;4;5;6;10;11",
                "5;4;3;2;1;0;1;7;8"
            });
        }

        [TestCleanup]
        public void Cleanup()
        {
            if (File.Exists(testFilePath))
                File.Delete(testFilePath);
        }

        [TestMethod]
        public void TestProcessMatrix_EighthColumn()
        {
            DataService ds = new DataService();

            int[,] matrix = ds.GetMatrix(testFilePath);
            int[,] result = ds.ProcessMatrix(matrix);

            // Проверяем восьмой столбец
            Assert.AreEqual(5, result[0, 7]);  // не изменяется
            Assert.AreEqual(-1, result[1, 7]); // !=5 -> -1
            Assert.AreEqual(5, result[2, 7]);  // не изменяется
            Assert.AreEqual(-1, result[3, 7]); // !=5 -> -1
            Assert.AreEqual(-1, result[4, 7]); // !=5 -> -1
        }
    }
}
