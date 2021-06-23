using System;

namespace z16
{
    class Program
    {
        static void Main(string[] args)
        {
            double m, r1, r2, energy;
            Console.WriteLine("Введите m");
            m = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите r1");
            r1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите r2");
            r2 = Convert.ToDouble(Console.ReadLine());

            energy = 6.67e-11 * 5.89e24 * m * ((1/r1) - (1/r2));
            Console.WriteLine(energy);


        }
    }
}
