using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hwork20
{
    class Program
    {
        delegate double CalcCircle(double r);
        static void Main(string[] args)
        {
            Console.Write("Введите радиус: ");
            double r = Convert.ToDouble(Console.ReadLine());
            CalcCircle calcCircle1 = Circle.Length;
            double length = calcCircle1(r);
            Console.WriteLine($"Длина окружности равна {length:f2}");
            CalcCircle calcCircle2 = Circle.Square;
            double square = calcCircle2(r);
            Console.WriteLine($"Площадь круга равна {square:f2}");
            CalcCircle calcCircle3 = Circle.Volume;
            double volume = calcCircle3(r);
            Console.WriteLine($"Объем шара равен {volume:f2}");
            Console.ReadKey();
        }
        static public class Circle
        {
            static public double Length(double r)
            {
                return 2 * Math.PI * r;
            }
            static public double Square(double r)
            {
                return Math.PI * r * r;
            }
            static public double Volume(double r)
            {
                return 4 * Math.PI * Math.Pow(r, 3) / 3;
            }
        }
    }
}
