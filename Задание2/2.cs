using System;

namespace Задание2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            Console.WriteLine("Введите прошедшее время(в секундах):");
            a = int.Parse(Console.ReadLine());
            c = a / 3600;
            b = (a - c * 3600) / 60;
            d = (a - c * 3600 - b * 60);
            Console.WriteLine($"Прошло {c} часов, {b} минут и {d} секунд.");
        }
    }
}
