using System;

namespace laba1
{
    class Program
    {
        static void Main()
        {
            float a = 40, b = 41;
            Console.WriteLine($"Поиск корня на отрезке [{a}, {b}]");
            Console.WriteLine("Точность: {0}", Constants.accuracy);
            SimpleIterations.Find(a, b);
            try
            {
                Newton.Find(a, b);
            }
            catch { Exception ex; }
            try
            {

                Hords.Find(a, b);
            }
            catch { Exception ex; }
        }
    }
}


