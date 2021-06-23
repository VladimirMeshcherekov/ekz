using System;

namespace n
{
    class Program
    {
        static void Main(string[] args)
        {
            double q, Vx, Vy, Vz, Bx, By, Bz;
            double Fxk, Fyk, Fzk, F;
            double cosVB, sinVB, ugolVB;
            double Vm, Bm;
            Console.WriteLine("Введите q");
            q = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите Vx");
            Vx = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите Vy");
            Vy = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите Vz");
            Vz = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите Bx");
            Bx = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите By");
            By = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите Bz");
            Bz = double.Parse(Console.ReadLine());
            Fxk = q * (Vy * Bz - Vz * By);
            Fyk = q * (Vz * Bx - Vx * Bz);
            Fzk = q * (Vx * By - Vy * Bx);
            Console.WriteLine("Fv = " + Fxk + "x+" + Fyk + "y+" + Fzk + "z" + " - вектор силы");
            cosVB = (Vx * Bx + Vy * By + Vz * Bz) / (Math.Sqrt(Vx * Vx + Vy * Vy + Vz * Vz) * Math.Sqrt(Bx * Bx + By * By + Bz * Bz));
            if (Vx * Vx + Vy * Vy + Vz * Vz == Vx * Bx + Vy * By + Vz * Bz & Bx * Bx + By * By + Bz * Bz == Vx * Vx + Vy * Vy + Vz * Vz)
            {
                Console.WriteLine("  0 град -  угол между B и V ");
                Console.WriteLine(" 0  - модуль силы");
            }
            else
            {
                sinVB = Math.Sqrt(1 - cosVB * cosVB);
            
             ugolVB = 180 / 3.14 * Math.Asin(sinVB);
             Console.WriteLine(ugolVB + " град -  угол между B и V ");
             Vm = Math.Sqrt(Vx * Vx + Vy * Vy + Vz * Vz);
             Bm = Math.Sqrt(Bx * Bx + By * By + Bz * Bz);
             F = q * sinVB * Vm * Bm;
             Console.WriteLine(F + " - модуль силы");
            }


        }
    }
}
