namespace laba1
{
    static public class SimpleIterations
    {
        private static float CalculateLambda(float a, float b)
        {
            float step = (b - a) / 100;
            float maxDeriv = float.NegativeInfinity;
            for (float x = a; x <= b; x += step)
            {
                float deriv = Math.Abs(Func.FuncPX(x));
                if (deriv > maxDeriv) maxDeriv = deriv;
            }
            // Знак лямбды противоположен знаку производной в середине отрезка
            float sign = Math.Sign(Func.FuncPX((a + b) / 2));
            return -1 / maxDeriv * sign;
        }
        private static float Phi(float x, float lambda) => x + lambda * Func.FuncX(x);

        /// <summary> Производная φ'(x) = 1 + λ f'(x) </summary>
        private static float PhiDeriv(float x, float lambda) => 1 + lambda * Func.FuncPX(x);

        /// <summary> Проверка достаточного условия сходимости |φ'(x)| < 1 на всём [a,b] </summary>
        private static bool CheckConvergence(float a, float b, float lambda)
        {
            float step = (b - a) / 100;
            for (float x = a; x <= b; x += step)
            {
                if (Math.Abs(PhiDeriv(x, lambda)) >= 1)
                    return false;
            }
            return true;
        }
        static public float Find(float a, float b)
        {   
            float lambda = CalculateLambda(a, b);
            if (!CheckConvergence(a, b, lambda))
            {
                Console.WriteLine("Предупреждение: условие |φ'(x)| < 1 не выполнено. Сходимость не гарантирована.");
                return 0;
            }
            float x = a, prev;
            int iter = 0;
            Console.WriteLine($"Метод простых итераций (лямбда: {lambda:F4})");

            do
            {
                prev = x;
                x = Phi(x,lambda);
                iter++;

                Console.WriteLine($"Итерация {iter}: x = {x:F10}");

                if (iter >= Constants.MaxIterations)
                {
                    Console.WriteLine("Достигнут лимит итераций! Возможно, метод расходится или точность слишком высока.");
                    break;
                }
            }
            while (Math.Abs(x - prev) > Constants.accuracy);

            return x;
        }
    }
}