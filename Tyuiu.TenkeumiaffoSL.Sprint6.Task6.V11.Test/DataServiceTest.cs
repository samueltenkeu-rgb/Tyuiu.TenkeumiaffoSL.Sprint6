using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.TenkeumiaffoSL.Sprint6.Task6.V11.Lib;

namespace Tyuiu.TenkeumiaffoSL.Sprint6.Task6.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCollectTextFromFile()
        {
            string path = "test_v11.txt";

            File.WriteAllLines(path, new string[]
            {
                "Завтра будет хороший день обязательно",
                "Мы сегодня пишем шестой таск спокойно",
                "Файл должен быть обработан правильно"
            });

            DataService ds = new DataService();
            string result = ds.CollectTextFromFile(path);

            Assert.AreEqual("день таск обработан", result);

            File.Delete(path);
        }
    }
}
