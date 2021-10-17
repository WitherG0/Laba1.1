using System;

namespace Задание1
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, c;
            Console.WriteLine("Введите дробное число(с запятой):");
            a = float.Parse(Console.ReadLine());
            int b = (int)a;
            c = (a - b) * 10;
            c = (int)c;
            Console.WriteLine($"0.x = {c}");
        }
    }
}
