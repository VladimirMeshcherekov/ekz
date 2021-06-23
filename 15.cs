using System;

namespace WaVeSsSss_number15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите N");
            int N = Convert.ToInt32(Console.ReadLine());
            if (N > 5)
            {
                return;
            }

            double px = 0;
            double py = 0;
            double pz = 0;

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Введите точку №{0}(m vx vy vz через пробел)", i + 1);
                string[] arr = Console.ReadLine().Split();
                double m = Convert.ToDouble(arr[0]);
                double vx = Convert.ToDouble(arr[1]);
                double vy = Convert.ToDouble(arr[2]);
                double vz = Convert.ToDouble(arr[3]);
                px += m * vx;
                py += m * vy;
                pz += m * vz;
            }

            double p = Math.Sqrt(px * px + py * py + pz * pz);
            Console.WriteLine("p = {0}", p);
        }
    }
}
