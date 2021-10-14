using System;

namespace Задание4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Введите первое число:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            b = int.Parse(Console.ReadLine());
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"ПЧ{a}, ВЧ{b}");
        }
    }
}
