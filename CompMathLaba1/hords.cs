
namespace laba1
{
    public static class Hords
    {
        public static float Find(float a, float b)
        {
            float x0 = ChooseX0(a, b), prev, x = x0 == a ? b : a;
            float funcX0 = Func.FuncX(x0);
            int iter = 0;

            Console.WriteLine("Метод Хорд:");

            do
            {
                prev = x;
                x = x - ((Func.FuncX(x) * (x - x0))/ (Func.FuncX(x) - funcX0));
                iter++;
                Console.WriteLine($"Итерация {iter}: x = {x:f10}");
            } while (Math.Abs(x - prev) > Constants.accuracy);

            return x;
        }
 
        public static float ChooseX0(float a, float b)
        {
            float x0;

            if (a > b) (a, b) = (b, a);

            if (Func.FuncPPX(a) * Func.FuncX(a) > 0) x0 = a;
            else if (Func.FuncPPX(b) * Func.FuncX(b) > 0) x0 = b;
            else throw new ArgumentException("Не найдено подходящее x0");

            return x0;
        }

    }
}
