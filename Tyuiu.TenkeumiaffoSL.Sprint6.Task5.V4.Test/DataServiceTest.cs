using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.TenkeumiaffoSL.Sprint6.Task5.V4.Lib;

namespace Tyuiu.TenkeumiaffoSL.Sprint6.Task5.V4.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestLoadFromDataFile()
        {
            // Создаем временный файл с тестовыми данными
            string path = "TestInput.txt";
            File.WriteAllText(path,
                "12 4.5 -7 0 3.1415 2.71828 -3.5 9 15.2567 1.9999\n" +
                "-2 -10.55 7.777 8 0.33333 45 -6.01 11.1111");

            DataService ds = new DataService();

            // Ожидаемый результат после округления до 3 знаков
            double[] expected =
            {
                12,
                4.5,
                -7,
                0,
                3.142,
                2.718,
                -3.5,
                9,
                15.257,
                2,
                -2,
                -10.55,
                7.777,
                8,
                0.333,
                45,
                -6.01,
                11.111
            };

            double[] result = ds.LoadFromDataFile(path);

            Assert.AreEqual(expected.Length, result.Length, "Размер массива неверный");

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], result[i], 0.001,
                    $"Элемент {i} неверен");
            }

            // Удаляем временный файл
            File.Delete(path);
        }
    }
}
