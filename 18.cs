using System;

namespace n
{
    class Program
    {
        static void Main(string[] args)
        {
               double velocity1, velocity2, mass1, mass2, energy1, energy2, energy1After, energy2After;
            double velocity1After, velocity2After;

            Console.Write("Введите начальную скорость первого шарика, в метрах в секунду:");
            velocity1 = Double.Parse(Console.ReadLine());

            Console.Write("Введите начальную скорость второго  шарика, в метрах в секунду:");
            velocity2 = Double.Parse(Console.ReadLine());

            Console.Write("Введите массу первого шарика, в килограммах:");
            mass1 = Double.Parse(Console.ReadLine());

            Console.Write("Введите массу второго шарика, в килограммах:");
            mass2 = Double.Parse(Console.ReadLine());

            energy1 = (mass1 * Math.Pow(velocity1, 2)) / 2;
            energy2 = (mass2 * Math.Pow(velocity2, 2)) / 2;
            velocity1After = ((mass1 - mass2) * velocity1 + 2 * mass2 * velocity2) / (mass1 + mass2);
            velocity2After = ((mass2 - mass1) * velocity2 + 2 * mass1 * velocity1) / (mass1 + mass2);
            energy1After = (mass1 * Math.Pow(velocity1After, 2)) / 2;
            energy2After = (mass2 * Math.Pow(velocity2After, 2)) / 2;

            Console.WriteLine($"Кинетическая энергия первого шарика до столкновения = {energy1} Дж");
            Console.WriteLine($"Кинетическая энергия второго шарика до столкновения = {energy2} Дж");

            Console.WriteLine($"Кинетическая энергия системы до столкновения = {energy2+energy1} Дж");

            Console.WriteLine($"скорость первого шарика после столкновения = {velocity1After} м/c");
            Console.WriteLine($"скорость второго шарика после столкновения = {velocity2After} м/c");

            Console.WriteLine($"Кинетическая энергия первого шарика после столкновения = {energy1After} Дж");
            Console.WriteLine($"Кинетическая энергия первого шарика после столкновения = {energy2After} Дж");
            Console.WriteLine($"Кинетическая энергия системы после столкновения= {Math.Round(energy2After+energy1After)} Дж");






        }
    }
}
