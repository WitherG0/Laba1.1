using System;

namespace Задание6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, k;
            Console.WriteLine("Введите четырехзначное число:");
            k = int.Parse(Console.ReadLine());
            a = k / 1000;
            b = (k - a * 1000) / 100;
            c = (k - a * 1000 - b * 100) / 10;
            d = k - a * 1000 - b * 100 - c * 10;
            Console.WriteLine(a*b*c*d);
        }
    }
}
