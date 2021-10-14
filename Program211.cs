using System;

namespace Laba1
{
    class Progra
    {
        static void Main(string[] args)
        {
            float a11, a21, a31, a12, a22, a32, a13, a23, a33, a14, a24, a34, ax, ay, az, ad;
            string p;
        metka:
            float x, y, z;
            do
            {
                Console.WriteLine("Дана система из трех уравнений вида ax+by+cz=d");
                Console.WriteLine("Введите a1");
                a11 = float.Parse(Console.ReadLine());
                Console.WriteLine("Введите b1");
                a12 = float.Parse(Console.ReadLine());
                Console.WriteLine("Введите c1");
                a13 = float.Parse(Console.ReadLine());
                Console.WriteLine("Введите d1, отличный от нуля");
                a14 = float.Parse(Console.ReadLine());
                if (a14 == 0) { do { Console.WriteLine("Введите значение, не равное нулю"); a14 = float.Parse(Console.ReadLine()); } while (a14 == 0); }
                Console.WriteLine("Введите a2");
                a21 = float.Parse(Console.ReadLine());
                Console.WriteLine("Введите b2");
                a22 = float.Parse(Console.ReadLine());
                Console.WriteLine("Введите c2");
                a23 = float.Parse(Console.ReadLine());
                Console.WriteLine("Введите d2, отличный от нуля");
                a24 = float.Parse(Console.ReadLine());
                if (a24 == 0) { do { Console.WriteLine("Введите значение, не равное нулю"); a24 = float.Parse(Console.ReadLine()); } while (a24 == 0); }
                Console.WriteLine("Введите a3");
                a31 = float.Parse(Console.ReadLine());
                Console.WriteLine("Введите b3");
                a32 = float.Parse(Console.ReadLine());
                Console.WriteLine("Введите c3");
                a33 = float.Parse(Console.ReadLine());
                Console.WriteLine("Введите d3, отличный от нуля");
                a34 = float.Parse(Console.ReadLine());
                if (a34 == 0) { do { Console.WriteLine("Введите значение, не равное нулю"); a34 = float.Parse(Console.ReadLine()); } while (a34 == 0); }
                Console.WriteLine("Вы ввели:");
                Console.WriteLine($"{a11}x+{a12}y+{a13}z={a14}");
                Console.WriteLine($"{a21}x+{a22}y+{a23}z={a24}");
                Console.WriteLine($"{a31}x+{a32}y+{a33}z={a34}");
                Console.WriteLine("Система уравнений верна?(y/n)");
                p = Console.ReadLine();

                if ((p == "n")) { goto metka; }
                else { break; }
            } while (p != "n");
            if (a11 == 0)
            {
                ax = a11;
                ay = a12;
                az = a13;
                ad = a14;
                a11 = a21;
                a12 = a22;
                a13 = a23;
                a14 = a24;
                a21 = ax;
                a22 = ay;
                a23 = az;
                a24 = ad;
            }
            if (a11 == 0)
            {
                ax = a11;
                ay = a12;
                az = a13;
                ad = a14;
                a11 = a31;
                a12 = a32;
                a13 = a33;
                a14 = a34;
                a31 = ax;
                a32 = ay;
                a33 = az;
                a34 = ad;
            }

            ax = a11 * a21 / a11;
            ay = a12 * a21 / a11;
            az = a13 * a21 / a11;
            ad = a14 * a21 / a11;
            a21 = a21 - ax;
            a22 = a22 - ay;
            a23 = a23 - az;
            a24 = a24 - ad;
            ax = a11 * a31 / a11;
            ay = a12 * a31 / a11;
            az = a13 * a31 / a11;
            ad = a14 * a31 / a11;
            a31 = a31 - ax;
            a32 = a32 - ay;
            a33 = a33 - az;
            a34 = a34 - ad;
            ay = a22 * a32 / a22;
            az = a23 * a32 / a22;
            ad = a24 * a32 / a22;
            a32 = a32 - ay;
            a33 = a33 - az;
            a34 = a34 - ad;
            z = a34 / a33;
            y = (a24 - a23 * z) / a22;
            x = (a14 - a13 * z - a12 * y) / a11;
            
            Console.WriteLine("Ответ:");
            Console.WriteLine($"x={x};y={y};z={z}");
        }
    }
}
