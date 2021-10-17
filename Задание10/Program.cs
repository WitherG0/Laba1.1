using System;

namespace Задание10
{
    class Program
    {
        static void Main(string[] args)
        {
            string n1, n2, n3, t1, t2, t3;
            float p1, p2, p3;
            int a1, a2, a3;
            Console.WriteLine("Будут добавлены три товара");
            Console.WriteLine("Название товара");
            n1 = Console.ReadLine();
            Console.WriteLine("Тип(К/О)");
            t1 = Console.ReadLine();
            /*if (t1 != "К" || t1 != "K" || t1 != "О" || t1 != "O") { Console.WriteLine("Неверное значение"); continue; }*/
            Console.WriteLine("Цена за единицу(грн)");
            p1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Количество");
            a1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Название товара");
            n2 = Console.ReadLine();
            Console.WriteLine("Тип(К/О)");
            t2 = Console.ReadLine();
            /*if (t2 != "К" || t2 != "K" || t2 != "О" || t2 != "O") { Console.WriteLine("Неверное значение"); }*/
            Console.WriteLine("Цена за единицу(грн)");
            p2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Количество");
            a2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Название товара");
            n3 = Console.ReadLine();
            Console.WriteLine("Тип(К/О)");
            t3 = Console.ReadLine();
            /*if (t3 != "К" || t3 != "K" || t3 != "О" || t3 != "O") { Console.WriteLine("Неверное значение"); }*/
            Console.WriteLine("Цена за единицу(грн)");
            p3 = float.Parse(Console.ReadLine());
            Console.WriteLine("Количество");
            a3 = int.Parse(Console.ReadLine());
            Console.WriteLine(new String('-', 76));
            Console.WriteLine($"|{" ",-26}{"Прайс-лист",-48}|");
            Console.WriteLine(new String('-', 76));
            Console.WriteLine($"{"|Наименование товара",-25}|{"Тип товара",-12}|{"Цена за 1 шт (грн)",-20}|{"Количество",-15}|");
            Console.WriteLine(new String('-', 76));
            Console.WriteLine($"|{n1,-24}|{t1,-12}|{p1,-20}|{a1,-15}|");
            Console.WriteLine(new String('-', 76));
            Console.WriteLine($"|{n2,-24}|{t2,-12}|{p2,-20}|{a2,-15}|");
            Console.WriteLine(new String('-', 76));
            Console.WriteLine($"|{n3,-24}|{t3,-12}|{p3,-20}|{a3,-15}|");
            Console.WriteLine(new String('-', 76));
        }
    }
}
