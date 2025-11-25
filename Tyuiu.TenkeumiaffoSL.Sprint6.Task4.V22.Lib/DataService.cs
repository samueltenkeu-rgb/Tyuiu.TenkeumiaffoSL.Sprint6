using System;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.TenkeumiaffoSL.Sprint6.Task4.V22.Lib
{
    public class DataService : ISprint6Task4V22
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int length = stopValue - startValue + 1;
            double[] arr = new double[length];

            for (int i = 0; i < length; i++)
            {
                double x = startValue + i;

                // Проверка деления на ноль (на случай изменения формулы)
                double denom = 2;
                if (Math.Abs(denom) < 1e-10)
                {
                    arr[i] = 0;
                }
                else
                {
                    double result =
                        Math.Sin(x) +
                        Math.Cos(2 * x) / 2 -
                        1.5 * x;

                    arr[i] = Math.Round(result, 2);
                }
            }

            return arr;
        }
    }
}
