using System;

namespace Задание3
{
    class Program
    {
        static void Main(string[] args)
        {
            int  a, b, c, p;
            double ang, ang1;
            Console.WriteLine("Введите прошедшее время");
            Console.WriteLine("Часы");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Минуты");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Секунды");
            c = int.Parse(Console.ReadLine());
            if (c>59)
            {
                c = c - 60;
                b = b + 1;
            }
            if (b > 59)
            {
                b = b - 60;
                a = a + 1;
            }
            if (a > 11)
            {
                a = a - 12;
            }
            ang = (a * 30 + b / 5 + c / 120);
            p = (int)ang;
            ang1 = (ang - p) * 60;
            Console.WriteLine($"Стрелка сместилась на {ang} градусов");
        }
    }
}
