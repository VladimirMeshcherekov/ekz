using System;

namespace n
{
    class Program
    {
        static void Main(string[] args)
        {
               double x, A, k, fase, m, t, t0; // t0 - период колебаний / 2
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

            x = A * Math.Sin(Math.Sqrt(m / k) * t + fase); // находим нашу координату
            t0 = (2 * 3.14 * Math.Sqrt(m / k))/2; // период колебаний / 2

            double x0 = A * Math.Sin(fase);     // находим максимальное отклонение от положения равновесия

            t = t % t0; // остаток от деления нашего времени на время колебаний, таким образом находим время за которое произошло движение от максимальной точки, до точки в которой находится тело в момент времени

            double v = (x0 - x) / t; // просто находим скорость
            double energy;

            if (A <= 2)
            {
                 energy = (m * x * x) / 2; // просто находим энергию по формуле малых колебаний
            }
            else
            {
                energy = (m * v * v) / 2; // нахом энергию с учётом потенциальной энергии
            }// просто находим энергию

            Console.WriteLine(energy);




        }
    }
}
