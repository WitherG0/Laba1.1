using System;

namespace Задание11
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, w, y, x, g, h;
            do
            {
                Console.WriteLine("ОДЗ: (a^2+b^2)>0; x!=0; x^1+b>=0;");
                Console.WriteLine("Введите значения переменных:\na:");
                a = double.Parse(Console.ReadLine());
                Console.WriteLine("b:");
                b = double.Parse(Console.ReadLine());
                Console.WriteLine("x:");
                x = double.Parse(Console.ReadLine());
                g = x * x + b;
                h = a * a + b * b;
                //if (x == 0) { if (g < 8) { if (h <= 0) { Console.WriteLine("Одно или более значений не удовлетворяют ОДЗ"); continue; } } }
                if (x == 0||g < 8||h <= 0) { Console.WriteLine("Одно или более значений не удовлетворяют ОДЗ"); continue; }
            } while (x == 0||g < 8||h <= 0);
            w = Math.Sqrt(g) - b * b * Math.Pow(Math.Sin(x + a), 3) / x;
            y = Math.Pow(Math.Cos(x * x * x), 2) - x / Math.Sqrt(h);
            Console.WriteLine($"W={w},\ay={y}");

        }
    }
}
