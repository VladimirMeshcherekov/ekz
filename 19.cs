using System;

namespace n
{
    class Program
    {
        static void Main(string[] args)
        {
             double m1, m2, v1, v2, V, Ebefore1, Ebefore2, Eafter1, Eafter2;
            Console.WriteLine("Введите начальные данные:");
            Console.Write("m1: "); m1 = Double.Parse(Console.ReadLine());
            Console.Write("v1: "); v1 = Double.Parse(Console.ReadLine());
            Console.Write("m2: "); m2 = Double.Parse(Console.ReadLine());
            Console.Write("v2: "); v2 = Double.Parse(Console.ReadLine());
            Ebefore1 = Math.Sqrt(m1 * v1 * v1 / 2);
            Ebefore2 = Math.Sqrt(m2 * v2 * v2 / 2);
            V = (m1 * v1 + m2 * v2) / (m1 + m2);
            Eafter1 = Math.Sqrt(m1 * V * V / 2);
            Eafter2 = Math.Sqrt(m2 * V * V / 2);
            Console.WriteLine("Энергия до столкновения 1 шарика: " + Ebefore1 + "    2 шарика: " + Ebefore2);
            Console.WriteLine("Скорости шариков после столкновения: " + V);
            Console.WriteLine("Энергия после столкновения 1 шарика: " + Eafter1 + "    2 шарика: " + Eafter2);






        }
    }
}
