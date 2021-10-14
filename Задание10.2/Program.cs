using System;

namespace Задание10.2{
{
    class Program
{
    static void Main(string[] args)
    {
        int[] mas = new int[100];
        int i = 0;
        string test;
        int count = 0;

        do
        {
            test = Console.ReadLine();
            if (test == "end") break;
            mas[i] = Convert.ToInt32(test);
            ++i; ++count;
        } while (true);

        Console.WriteLine("Vivod: ");
        for (int j = 0; j < count; j++)
        {
            Console.Write("{0} ", mas[j]);
        }
    } Console.ReadLine();
}
}