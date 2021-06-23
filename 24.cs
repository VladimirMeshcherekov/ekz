using System;

namespace n
{
    class Program
    {
        static void Main(string[] args)
        {
              Console.WriteLine("Введите N");
            int N = Convert.ToInt32(Console.ReadLine());
            if (N < 2 || N > 5)
            {
                return;
            }
            double G = 6.67 * Math.Pow(10, -11);
            double Wp0 = 0;

            Console.WriteLine("Введите точку №1(m x y через пробел");
            string[] arr = Console.ReadLine().Split();
            double m0 = Convert.ToDouble(arr[0]);
            double x0 = Convert.ToDouble(arr[1]);
            double y0 = Convert.ToDouble(arr[2]);

            for (int i = 1; i < N; i++)
            {
                Console.WriteLine("Введите точку №{0}(m x y через пробел)", i + 1);
                string[] arr1 = Console.ReadLine().Split();
                double m = Convert.ToDouble(arr1[0]);
                double x = Convert.ToDouble(arr1[1]);
                double y = Convert.ToDouble(arr1[2]);
                // по закону всемирного тяготения Ep = G * m0 * m / r

                double r = Math.Sqrt((x0 - x) * (x0 - x) + (y0 - y) * (y0 - y));
                double Wp = G * m0 * m / r;
                Wp0 += Wp;
            }
            Console.WriteLine(Wp0);




        }
    }
}
