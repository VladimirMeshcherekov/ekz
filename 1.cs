using System;
//никитин лох
namespace n
{
    class Program
    {
        static void Main(string[] args)
        {
            int V, W, R, at, an;
            Console.WriteLine("Введите угловую скорость");
            W = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите радиус");
            R = int.Parse(Console.ReadLine());
            V = W * R;
            at = W * W * R;
            an = V * V / R;
            Console.WriteLine(V + " -лин скорость " + at + " -тангенц уск " + an + " -норм уск ");
        }
    }
}
