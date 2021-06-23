using System;

namespace n
{
    class Program
    {
        static void Main(string[] args)
        {
          const double G = 9.81;
            double startAngle, angle, w, time, mass, length, energy;
            Console.Write("Введите начальный угол маятника, в градусах:");
            startAngle = Double.Parse(Console.ReadLine());

            Console.Write("Введите длину маятника, в метрах:");
            length = Double.Parse(Console.ReadLine());

            Console.Write("Введите массу груза, в килограммах:");
            mass = Double.Parse(Console.ReadLine());

            Console.Write("Введите время, в секундах:");
            time = Double.Parse(Console.ReadLine());

            w = Math.Sqrt(G / length);

            angle = startAngle * Math.Cos(w * time);

            energy = (mass * Math.Pow(length, 2) * Math.Pow(angle, 2)) / 2;
            Console.WriteLine($"при времени = {time} сек., кинетическая энергия маятника будет равна {energy} Дж.");



        }
    }
}
