using System;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.TenkeumiaffoSL.Sprint6.Task1.V11.Lib
{
    public class DataService : ISprint6Task1V11
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int length = stopValue - startValue + 1;
            double[] arr = new double[length];

            for (int i = 0; i < length; i++)
            {
                double x = startValue + i;

                double denominator = Math.Sin(x) + 3;

                if (Math.Abs(denominator) < 1e-10)
                {
                    arr[i] = 0;
                }
                else
                {
                    double result =
                        (5 * x + 2.5) / denominator +
                        2 * x +
                        Math.Cos(x);

                    arr[i] = Math.Round(result, 2);
                }
            }

            return arr;
        }
    }
}
