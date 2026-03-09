using System;
using System.Threading;

namespace laba1;

public static class Func
{
    public static float FuncX(float x) => 100* x * x - 10000 * x - 5;
    public static float FuncPX(float x) => 200 * x - 10000;
    public static float FuncPPX(float x) => 200;
    //public static float FuncX(float x) => Math.Exp(x) - 4 * x * x - 3 * x;
    //public static float FuncPX(float x) => Math.Exp(x) - 8 * x - 3;
    //public static float FuncPPX(float x) => Math.Exp(x) - 8;
}