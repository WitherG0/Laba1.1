using System;

namespace Задание7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            string i, rev;
            Console.WriteLine("Введите трехзначное число");
            a = int.Parse(Console.ReadLine());
            if (a>999 ^ a<100)
            {do
             {
                Console.WriteLine("Число не трёхзначное, попробуйте еще раз");
                a = int.Parse(Console.ReadLine());
             }while (a>999 ^ a<100);
            }
            i = a.ToString();
            char[] inputarray = i.ToCharArray();
            Array.Reverse(inputarray);
            rev = new string(inputarray);
            Console.WriteLine(rev);
        }
    }
}
