using System;

namespace n
{
    class Program
    {
        static void Main(string[] args)
        {
          int t, x, y, z, Vx, Vy, Vz;
                int T, X, Y, Z, V, VX, VY, VZ;
                string selection;
                Console.WriteLine("Введите исходный параметр t");
                t = Convert.ToInt32(Console.ReadLine());
            if (t < 0)
            {
                Console.WriteLine("время не может быть отриц");
            }
            else
            {


                Console.WriteLine("Введите исходный параметр x");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите исходный параметр y");
                y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите исходный параметр z");
                z = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите исходный параметр Vx");
                Vx = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите исходный параметр Vy");
                Vy = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите исходный параметр Vz");
                Vz = Convert.ToInt32(Console.ReadLine());
                V = Convert.ToInt32(Math.Sqrt((Vx * Vx) + (Vy * Vy) + (Vz * Vz)));
                Console.WriteLine("Скорость движения подвижной системы относительно неподвижной:" + V);
                T = t;
                Console.WriteLine("Время подвижной системы относительно неподвижной:" + T);
                X = x - V * T;
                Console.WriteLine("Координата х подвижной системы относительно неподвижной:" + X);
                Y = y;
                Console.WriteLine("Координата у подвижной системы относительно неподвижной:" + Y);
                Z = z;
                Console.WriteLine("Координата z подвижной системы относительно неподвижной:" + Z);
                VX = Vx + V;
                Console.WriteLine("Скорость от-но координаты х подвижной системы относительно неподвижной:" + VX);
                VY = Vy + V;
                Console.WriteLine("Скорость от-но координаты y подвижной системы относительно неподвижной:" + VY);
                VZ = Vz + V;
                Console.WriteLine("Скорость от-но координаты z подвижной системы относительно неподвижной:" + VZ);
                Console.WriteLine("Провести обратные вычисления?(Y)");
                selection = Console.ReadLine();
                if (selection == "Y")
                {
                    Console.WriteLine("Время неподвижной системы:" + t);
                    Console.WriteLine("Координата х неподвижной системы:" + x);
                    Console.WriteLine("Координата у неподвижной системы:" + y);
                    Console.WriteLine("Координата z неподвижной системы:" + z);
                    Console.WriteLine("Скорость от-но координаты х неподвижной системы:" + Vx);
                    Console.WriteLine("Скорость от-но координаты y неподвижной системы:" + Vy);
                    Console.WriteLine("Скорость от-но координаты z неподвижной системы:" + Vz);
                }
                Console.ReadKey();
            }

        }
    }
}
