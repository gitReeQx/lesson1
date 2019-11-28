using System;

// Кузнецов Е.А.
// Создать класс с методами, которые могут пригодиться в вашей учебе (Print, Pause).

namespace Geekbrains
{
    public class MyMethods
    {
        public static void Print(string ms, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(ms);
        }

        public static void Pause()
        {
            Console.ReadLine();
        }
    }
}