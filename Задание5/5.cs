using System;

namespace Задание5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            float s, p, g;
            Console.WriteLine("Длина первого катета:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Длина второго катета:");
            b = int.Parse(Console.ReadLine());
            s = (a * b) / 2;
            g = (float)Math.Sqrt(a * a + b * b);
            p = a + b + g;
            Console.WriteLine($"Площадь {s}, периметр {p}");
        }
    }
}
