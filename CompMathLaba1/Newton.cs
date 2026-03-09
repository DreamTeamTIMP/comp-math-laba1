namespace laba1
{
    static public class Newton
    {
        public static float Find(float a, float b)
        {
            float x = ChooseX0(a,b), prev;
            int iter = 0;
            Console.WriteLine("Метод Ньютона;");
            do
            {
                prev = x;
                x = x - (Func.FuncX(x) / Func.FuncPX(x));
                iter++;
                Console.WriteLine($"Итерация {iter}: x = {x:f10}");
                if (iter >= Constants.MaxIterations) break;
            } while (Math.Abs(x - prev) > Constants.accuracy);

            return x;
        }

        public static float ChooseX0(float a, float b)
        {
            // Упорядочиваем границы
            if (a > b) (a, b) = (b, a);

            // Проверяем условие f(x)*f''(x) > 0 на концах
            if (Func.FuncPPX(a) * Func.FuncX(a) > 0) return a;
            if (Func.FuncPPX(b) * Func.FuncX(b) > 0) return b;

            throw new ArgumentException("Не найдено подходящее x0 на концах отрезка. Измените интервал.");
        }
    }
}