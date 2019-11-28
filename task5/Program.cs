using System;

// Кузнецов Е.А.
// а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
// б) * Сделать задание, только вывод организовать в центре экрана.
// в) ** Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y).

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            string userData = "Евгений Кузнецов, г. Бодайбо";
            int x = 40;
            int y = 13;
            Print(userData, x, y);
        }

        static void Print(string ms, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(ms);
            Console.ReadLine();
        }
    }
}