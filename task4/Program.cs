using System;

// Кузнецов Е.А.
// Написать программу обмена значениями двух переменных:
// а) с использованием третьей переменной;
// б) * без использования третьей переменной.

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;     
            int b = 2;     
            int temp = a;       
            a = b;         
            b = temp;
            Console.WriteLine($"{ a}, { b}");

            /////////////////////////////////

            int c = 1;
            int d = 2;
            c = c + d;
            d = c - d;
            c = c - d;
            Console.WriteLine($"{ c}, { d}");

            Console.ReadLine();
        }

    }
}
