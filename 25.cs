using System;

namespace n
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
            double w0 = 0;
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Введите точку №{0}(m vx vy vz через пробел)", i+1);
                string[] arr = Console.ReadLine().Split();
                double m = Convert.ToDouble(arr[0]);
                double vx = Convert.ToDouble(arr[1]);
                double vy = Convert.ToDouble(arr[2]);
                double vz = Convert.ToDouble(arr[3]);

                double v = Math.Sqrt(vx*vx + vy*vy + vz*vz);
                double W = 0.5 * m * v * v; // формула кинетической
                w0 += W;
            }
            Console.WriteLine(w0);




        }
    }
}
