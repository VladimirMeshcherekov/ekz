using System;

namespace z12
{
    class Program
    {
        static void Main(string[] args)
        {
           double T, Rs, r;
        double M = 5.98e24, G = 6.67e-11;
        Console.WriteLine("введите r");
        r = double.Parse(Console.ReadLine());
        T = Math.Sqrt((Math.Pow(2 * Math.PI, 2) * Math.Pow(r, 3))/(G*M));
        Console.WriteLine(T + " - период обращения");
        Console.WriteLine("введите Ms");
        double Ms = double.Parse(Console.ReadLine());

        Rs = Math.Pow( (G * Ms * T * T)/(4 * Math.Pow(Math.PI, 2)) , (1/3.0)) ;
        Console.WriteLine(Rs + " - стационарная орбита");
          


        }
    }
}
