using System;
using laba1;

namespace laba1;


static public class SimpleIters
{
    static public float MaxFPXOnAB(float a, float b, int stepCount)
    {
        if(a > b)
        {
            float temp = a;
            a = b;
            b = a;
        }

        float step = (b - a) / stepCount;

        float max = -1;

        for (int i = 0; i <= stepCount; i++)
        {
            float currX = a + step * i;
            float currFPX = MathF.Abs((Func.FuncPX(currX)));
            max = MathF.Max(currFPX, max);
        }

        return max;
    }
    static public float Lambda(float a, float b, int stepCount) => - 1 / MaxFPXOnAB(a, b, stepCount);

    static public float Phi(float x, float lambda) => x + Func.FuncX(x) * lambda;

    static public float Find(float a, float b, int stepCount, int maxIterCount)
    {
        float lambda = Lambda(a, b, stepCount);

        for (int i = 0; i < maxIterCount; i++)
        {
            
        }
    }
}