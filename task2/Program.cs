using System;

// Кузнецов Е.А.
// Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах.

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите рост в метрах: ");
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите вес: ");
            int weight = int.Parse(Console.ReadLine());

            Calc(height, weight);
        }

        static void Calc(double h, int m)
        {
            double IMT = m / (h * h);
            Console.WriteLine($"Индекс массы тела равен: {Math.Round(IMT, 2)}");
            Console.ReadLine();
        }
    }
}