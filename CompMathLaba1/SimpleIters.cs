using System;
using laba1;


/*
 * Формулы: 
 */
namespace laba1
{
    static public class SimpleIters
    {
        static public double MaxFPXOnAB(double a, double b, int stepCount)
        {
            if (a > b)
            {
                double temp = a;
                a = b;
                b = temp;
            }

            double step = (b - a) / stepCount;
            double max = -1;
            bool isNegative = false;

            for (int i = 0; i <= stepCount; i++)
            {
                double currX = a + step * i;
                double currFPX = Math.Abs((Func.FuncPX(currX)));
                max = Math.Max(currFPX, max);
                if (i == stepCount && Func.FuncPX(currX)<0) isNegative = true;
            }
            if (isNegative) return max;
            else return - max;
        }
        static public double Lambda(double a, double b, int stepCount) =>  1 / MaxFPXOnAB(a, b, stepCount);

        static public double Phi(double x, double lambda) => x + Func.FuncX(x) * lambda;
        public static double FuncFiX(double x) => x + Func.FuncX(x);

        public const double accuracy = 0.001;
        static public double Find(double a, double b, int stepCount)
        {
            double lambda = Lambda(a, b, stepCount);
            double x = a, prev;
            do
            {
                prev = x;
                x = x + lambda * Func.FuncX(x);
            }
            while (Math.Abs(x - prev) > accuracy);
            return x;
        }
    }
}