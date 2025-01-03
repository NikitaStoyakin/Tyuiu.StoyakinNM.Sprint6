﻿using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.StoyakinNM.Sprint6.Task0.V12.Lib
{
    public class DataService : ISprint6Task0V12
    {
        public double Calculate(int x)
        {
            double res = (Math.Pow(x, 2) + 1) / Math.Sqrt(4 * Math.Pow(x, 2) - 3);
            return Math.Round(res, 3);
        }
    }
}
