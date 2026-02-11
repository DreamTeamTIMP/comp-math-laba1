using System;
using System.Threading;

namespace laba1;

public static class Func
{
    public static float FuncX(float x) => MathF.Exp(x) - 4 * x * x - 3 * x;
    public static float FuncPX(float x) => MathF.Exp(x) - 8 * x - 3;
}