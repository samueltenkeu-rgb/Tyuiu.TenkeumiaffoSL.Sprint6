using System;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.TenkeumiaffoSL.Sprint6.Task0.V16.Lib
{
    public class DataService : ISprint6Task0V16
    {
        public double Calculate(int x)
        {
            if (x == 0)
                throw new DivideByZeroException("Деление на ноль невозможно!");

            double result = (1 + Math.Pow(x, 3)) / (x * x);
            return Math.Round(result, 3);
        }
    }
}
