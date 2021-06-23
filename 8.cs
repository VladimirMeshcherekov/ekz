using System;

namespace Zadacha9
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            double[] m, x, y, z;
            double X_center = 0, X_center_num = 0, X_center_den = 0;
            double Y_center = 0, Y_center_num = 0, Y_center_den = 0;
            double inert_z = 0;
            Console.WriteLine("Введите количество масс системы (до 5):");
            number = Convert.ToInt32(Console.ReadLine());
            //Устанавлиаем размеры массивов
            m = new double[number];
            x = new double[number];
            y = new double[number];
            z = new double[number];
            //ВВОД ДАННЫХ
            Console.WriteLine("Введите массу m, и координаты x, y, z каждой точки.");
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine(i.ToString() + "я точка:");
                Console.WriteLine("m_" + i.ToString() + ":");
                m[i - 1] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("x_" + i.ToString() + ":");
                x[i - 1] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("y_" + i.ToString() + ":");
                y[i - 1] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("z_" + i.ToString() + ":");
                z[i - 1] = Convert.ToDouble(Console.ReadLine());
            }
            //Расчёт центра масс системы
            X_center_num = 0;
            X_center_den = 0;
            Y_center_num = 0;
            Y_center_den = 0;

            for (int i = 0; i < m.Length; i++) {
                X_center_num += m[i] * x[i];
                X_center_den += m[i];
                Y_center_num += m[i] * y[i];
                Y_center_den += m[i];
            }
            X_center = X_center_num / X_center_den;
            Y_center = Y_center_num / Y_center_den;
            Console.WriteLine("Центр масс системы: (" + X_center.ToString() + "; " + Y_center.ToString() + ")");
        }
    }
}