using System;

namespace n
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, x1,x2,X,x0;
            double x1i, x2i, x1id,x1im,x2id, x2im;
            Console.WriteLine("Введите коэф а");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите коэф b");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите коэф c");
            c = double.Parse(Console.ReadLine());
            double d = Math.Sqrt(b * b - 4 * a * c);
            if ((a == 0 & b == 0 & c==0) || (a==0 & b==0))
            {
                Console.WriteLine("не задано уравн");
            }
            else
            {
                if (a == 0)
                {
                    x0 = -c / b;
                    Console.WriteLine(x0 + " -корень уравн");
                }
                else
                {
                    if (b == 0 & c > 0)
                    {
                        x1i = Math.Sqrt(c);
                        x2i = -Math.Sqrt(c);

                        Console.WriteLine(x1i + "i - первый кор");
                        Console.WriteLine(x2i + "i - втор кор");
                    }
                    else
                    {
                        if ((b * b - 4 * a * c) < 0)
                        {
                x1id = -b / 2;
                x1im = Math.Sqrt((b * b - 4 * a * c)*(-1));
                x2id = -b / 2;
                x2im = Math.Sqrt((b * b - 4 * a * c) * (-1));
                Console.WriteLine(x1id + "+" + x1im + "i - первый кор");
                Console.WriteLine(x2id + "-" + x2im + "i - втор кор");
                        }
                        else
                        {
                            x1 = (-b + d) / (2 * a);
                            x2 = (-b - d) / (2 * a);

                            if (x1 == x2)
                            {
                                X = x1;
                                Console.WriteLine(X + " - корень уравнения");
                            }
                            else
                            {
                      Console.WriteLine(x1 + " и " + x2 + " - корни уравнения");
                            }
                        }
                    }
                }
            }

        }
    }
}
