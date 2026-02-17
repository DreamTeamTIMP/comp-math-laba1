using System;

namespace laba1
{


    class Program
    {
        static int Main()
        {
            Console.WriteLine($"{SimpleIters.Lambda(0, 1, 100)} MAXFUNCPX: {SimpleIters.MaxFPXOnAB(0, 1, 100)} X: {SimpleIters.Find(0,1,100)}");

            Console.WriteLine($"{SimpleIters.Lambda(4, 5, 100)} MAXFUNCPX: {SimpleIters.MaxFPXOnAB(4, 5, 100)} X: {SimpleIters.Find(4, 5, 1000)}");


            Console.WriteLine($"{SimpleIters.Lambda(-1, -0.8, 100)} MAXFUNCPX: {SimpleIters.MaxFPXOnAB(-1, -0.8, 100)} X: {SimpleIters.Find(-1, -0.8, 1000)}");
            return 0;
        }
    }
}


