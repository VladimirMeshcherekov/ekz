using System;

namespace n
{
    class Program
    {
        static void Main(string[] args)
        {
            double h1,h2, V1, V2, E1, E2, E, m, r0 = 6.5310e6, G = 6.67e-11, M = 5.98e24;
            Console.WriteLine("Задача17");
            Console.Write("Введите m(кг): ");
            m=Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите h1(м): ");
            h1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите h2(м): ");
            h2 = Convert.ToDouble(Console.ReadLine());
            V1 = Math.Sqrt(G * M / r0 + h1);
            V2 = Math.Sqrt(G * M / r0 + h2);
            E1 = m * Math.Pow(V1, 2) / 2;
            E2 = m * Math.Pow(V2, 2) / 2;
            E = E2 - E1;
            Console.WriteLine($"Изменение кинетической энергии(Дж): {E}");





        }
    }
}
