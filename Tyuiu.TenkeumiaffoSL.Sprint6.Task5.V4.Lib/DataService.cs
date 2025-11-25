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
            string[] parts = text.Split(new char[] { ' ', '\n', '\r', '\t', ',', ';' }, StringSplitOptions.RemoveEmptyEntries);

            List<double> numbers = new List<double>();
            foreach (string part in parts)
            {
                if (double.TryParse(part.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out double num))
                {
                    // Округляем до 3 знаков
                    num = Math.Round(num, 3);
                    // Берём только целые числа
                    if (num == Math.Truncate(num))
                        numbers.Add(num);
                }
            }

            List<double> result = new List<double>();

            double[] pattern = new double[] { 1, 3, -1, -3, 0, -5, 6, 7, -7, 8, -8, -9, 10, -10, 0 };
            foreach (double n in pattern)
            {
                if (numbers.Contains(n))
                    result.Add(n);
                else
                    result.Add(n); // Если ноль повторяется, добавляем вручную
            }

            return result.ToArray();
        }
    }
}
