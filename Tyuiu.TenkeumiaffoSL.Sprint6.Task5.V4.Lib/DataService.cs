using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.TenkeumiaffoSL.Sprint6.Task5.V4.Lib
{
    public class DataService : ISprint6Task5V4
    {
        public double[] LoadFromDataFile(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException($"Файл не найден: {path}");

            string text = File.ReadAllText(path);

            // Разделители: пробел, табуляция, перенос строки
            string[] parts = text.Split(new char[] { ' ', '\n', '\r', '\t', ',', ';' }, StringSplitOptions.RemoveEmptyEntries);

            List<double> result = new List<double>();

            foreach (string part in parts)
            {
                if (double.TryParse(part.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out double num))
                {
                    // Берем только целые числа
                    if (num == Math.Truncate(num))
                    {
                        result.Add(Math.Round(num, 3));
                    }
                }
            }

       
            List<double> finalResult = new List<double>();
            foreach (double n in result)
            {
                if (!finalResult.Contains(n))
                    finalResult.Add(n);
            }

            return finalResult.ToArray();
        }
    }
}
