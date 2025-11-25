using System;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.TenkeumiaffoSL.Sprint6.Task2.V18.Lib
{
    public class DataService : ISprint6Task2V18
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int length = stopValue - startValue + 1;
            double[] arr = new double[length];

            for (int i = 0; i < length; i++)
            {
                double x = startValue + i;

                double denominator = 4 * x - 0.5;

                // Проверка деления на 0
                if (Math.Abs(denominator) < 1e-10)
                {
                    arr[i] = 0;
                }
                else
                {
                    double result =
                        (3 * Math.Cos(x)) / denominator +
                        Math.Sin(x) -
                        5 * x -
                        2;

                    arr[i] = Math.Round(result, 2);
                }
            }

            return arr;
        }
    }
}
