using System;

namespace n
{
    class Program
    {
        static void Main(string[] args)
        {
          double q, r, k, e0 = 8.85e-12, E, F, f;
            k = 1 / (4 * Math.PI * e0);
            Console.WriteLine("Задача7");
            Console.Write("Введите r(м): ");
            r = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите q(Кл): ");
            q = Convert.ToDouble(Console.ReadLine());

            E = k * (q / Math.Pow(r, 2));//"Энергия
            F = E * q;//Силы
            f = k * (q / r);//Потенциал
            Console.WriteLine($"Энергия(Дж): {E}\nСила(Н): {F}\nПотенциал(Вольт): {f} ");


        }
    }
}
