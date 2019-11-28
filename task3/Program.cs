using System;

// Кузнецов Е.А.
// а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
// б) * Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dot dot1 = new Dot(10, 45);
            Dot dot2 = new Dot(27, 83);

            Calc(dot1.x, dot2.x, dot1.y, dot2.y);
        }

        static void Calc(double x1, double x2, double y1, double y2)
        {
            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine($"Расстояние между точками: {Math.Round(r, 2)}");
            Console.ReadLine();
        }
    }
}