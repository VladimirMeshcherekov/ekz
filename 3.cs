using System;

namespace n
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, Fx, Fy,A;
            double cosFS,Fm, Sm,ugol;
            Console.WriteLine("Введите Fx");
            Fx = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите коэф Fy");
            Fy = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите коэф x");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите коэф y");
            y = double.Parse(Console.ReadLine());
            Console.WriteLine("A=Fv*Sv=F*S*cos(F,S)=x*Fx+y*Fy");
            A = x * Fx + y * Fy;
            Console.WriteLine(A + " - работа силы");
            Fm = Math.Sqrt(Fx * Fx + Fy * Fy);
            Sm = Math.Sqrt(x * x + y * y);
            cosFS = (A / (Fm * Sm));
            ugol = Math.Acos(cosFS);
            Console.WriteLine(ugol + " град - угол между силой и перем");

        }
    }
}
