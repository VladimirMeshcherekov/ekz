using System;

namespace zadanie14
{
    class Program
    {
        static void Main(string[] args)
        {
            int t, x, y, z, V;
            int T, X, Y, Z;
            const int C = 3*10^8; 
            Console.WriteLine("Введите исходный параметр t");
            t = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите исходный параметр x");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите исходный параметр y");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите исходный параметр z");
            z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите исходный параметр V");
            V = Convert.ToInt32(Console.ReadLine());
            Y = y;
            Console.WriteLine("Координата у подвижной системы относительно неподвижной:" + Y);
            Z = z;
            Console.WriteLine("Координата z подвижной системы относительно неподвижной:" + Z);
            T = Convert.ToInt32((t - (V*x / C * C)) / (Math.Sqrt(1 - ((V*V) / (C * C)))));
            Console.WriteLine("Время подвижной системы относительно неподвижной:" + T);
            X = Math.Abs(Convert.ToInt32((x - V * t) / (Math.Sqrt(1 - ((V*V) / (C * C))))));
            Console.WriteLine("Координата х подвижной системы относительно неподвижной:" + X);
            Console.ReadKey();



        }
    }
}
