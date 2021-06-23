using System;

namespace n
{
    class Program
    {
        static void Main(string[] args)
        {
                      double Teta, Teta0, w, t, L, M, g = 9.81, U;
            Console.WriteLine("Введите начальные данные:");
            Console.Write("L: "); 
              L = Double.Parse(Console.ReadLine());
            Console.Write("Teta0: ");
             Teta0 = Double.Parse(Console.ReadLine());
            Console.Write("M: ");
             M = Double.Parse(Console.ReadLine());
            Console.Write("Введите время: ");
            t = Double.Parse(Console.ReadLine());
            w = Math.Sqrt(g / L);
            Teta = Teta0 * Math.Cos(w * t * Math.PI / 180);
            U = M * g * L * (1 - Math.Cos(Teta));
            Console.WriteLine("Потенц. энергия: " + U);




        }
    }
}
