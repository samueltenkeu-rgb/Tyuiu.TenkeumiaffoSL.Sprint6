using System;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.TenkeumiaffoSL.Sprint6.Task3.V16.Lib
{
    public class DataService : ISprint6Task3V16
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            // Копируем исходный массив
            int[,] result = (int[,])matrix.Clone();

            // Третья строка — индекс 2
            for (int j = 0; j < cols; j++)
            {
                if (result[2, j] % 2 == 0) // если четное
                {
                    result[2, j] = 0;
                }
            }

            return result;
        }
    }
}
