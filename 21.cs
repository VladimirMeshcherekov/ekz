using System;

namespace n
{
    class Program
    {
        static void Main(string[] args)
        {
              double v1, v2, m1, m2, k;
            Console.WriteLine("Введите v1");
            v1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите v2");
            v2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите m1");
            m1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите m2");
            m2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите k");
            k = Convert.ToDouble(Console.ReadLine());

            double energy0, energy, lost_energy;
            energy0 = ((m1 * v1 * v1) / 2) + ((m2 * v2 * v2) / 2);
            lost_energy = ((m1 * m2) / (2 * (m1 + m2))) * Math.Pow((v1 - v2), 2) * (1 - (k * k));
            energy = energy0 - lost_energy;

            Console.WriteLine("Энергия до столкновения" + energy0);
            Console.WriteLine("Энергия после столкновения" + energy);
            Console.WriteLine("потерянная энергия" + lost_energy);


        }
    }
}
