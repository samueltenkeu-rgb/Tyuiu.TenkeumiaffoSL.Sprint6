using System;
using System.IO;
using System.Linq;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.TenkeumiaffoSL.Sprint6.Task7.V21.Lib
{
    public class DataService : ISprint6Task7V21
    {
        public int[,] GetMatrix(string path)
        {
            string[] lines = File.ReadAllLines(path);
            int rows = lines.Length;
            int cols = lines[0].Split(';').Length;
            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                int[] values = lines[i].Split(';').Select(s => int.Parse(s.Trim())).ToArray();
                for (int j = 0; j < cols; j++)
                    matrix[i, j] = values[j];
            }

            return matrix;
        }

        public int[,] ProcessMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int[,] result = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = matrix[i, j]; // копируем по умолчанию
                }

                // Обработка 8-го столбца (индекс 7)
                if (cols > 7)
                {
                    if (result[i, 7] != 5)
                        result[i, 7] = -1;
                }
            }

            return result;
        }


        public void SaveMatrix(int[,] matrix, string path)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            string[] lines = new string[rows];

            for (int i = 0; i < rows; i++)
            {
                string[] row = new string[cols];
                for (int j = 0; j < cols; j++)
                    row[j] = matrix[i, j].ToString();
                lines[i] = string.Join(";", row);
            }

            File.WriteAllLines(path, lines);
        }
    }
}
