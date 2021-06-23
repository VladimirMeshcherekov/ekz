using System;

namespace n
{
    class Program
    {
        static void Main(string[] args)
        {
             double G = 6.67 * Math.Pow(10, -11);

            Console.WriteLine("Введите точку №1(m x y vx vy через пробел)");
            string[] arr = Console.ReadLine().Split();
            double m0 = Convert.ToDouble(arr[0]);
            double x0 = Convert.ToDouble(arr[1]);
            double y0 = Convert.ToDouble(arr[2]);
            double vx0 = Convert.ToDouble(arr[3]);
            double vy0 = Convert.ToDouble(arr[4]);

            Console.WriteLine("Введите точку №2(m x y vx vy через пробел)");
            string[] arr1 = Console.ReadLine().Split();
            double m = Convert.ToDouble(arr1[0]);
            double x = Convert.ToDouble(arr1[1]);
            double y = Convert.ToDouble(arr1[2]);
            double vx = Convert.ToDouble(arr1[3]);
            double vy = Convert.ToDouble(arr1[4]);

            double r = Math.Sqrt((x0 - x) * (x0 - x) + (y0 - y) * (y0 - y));
            double Wp = G * m0 * m / r;

            double v1 = Math.Sqrt(vx0 * vx0 + vy0 * vy0 );
            double W1 = 0.5 * m * v1 * v1;
            double v2 = Math.Sqrt(vx * vx + vy * vy);
            double W2 = 0.5 * m * v2 * v2;

            double W0 = W1 + W2 + Wp;
            Console.WriteLine(W0);






        }
    }
}
