using System;

namespace z12
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, A, k, fase, m, t, t0; 
            Console.WriteLine("Введите амплитуду");
            A = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите коэф. жёсткости пружины");
            k = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите начальную фазу");
            fase = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите массу");
            m = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите время");
            t = Convert.ToDouble(Console.ReadLine());

            x = A * Math.Sin(Math.Sqrt(m / k) * t + fase); 
           
            double energy = (k*x*x)/2;

      

            Console.WriteLine(energy);

          


        }
    }
}
