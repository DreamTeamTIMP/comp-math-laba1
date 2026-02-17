using System;
using System.Threading;

namespace laba1;

public static class Func
{
    public static double FuncX(double x) => Math.Exp(x) - 4 * x * x - 3 * x;
    public static double FuncPX(double x) => Math.Exp(x) - 8 * x - 3;
    public static double FuncPPX(double x) => Math.Exp(x) - 8;
}