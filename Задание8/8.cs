using System;

namespace Задание8
{
    class Program
    {
        static void Main(string[] args)
        {
            float x, y;
            Console.WriteLine("Введите х:");
            x = float.Parse(Console.ReadLine());
            y = (((3 * x - 5) * x + 2) * x - 1) * x + 7;
            Console.WriteLine(y);
        }
    }
}
