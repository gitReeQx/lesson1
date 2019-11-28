using System;

// Кузнецов Е.А.
// Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя:");
            string name = Console.ReadLine();

            Console.Write("Введите фамилию:");
            string surname = Console.ReadLine();

            Console.Write("Введите возраст:");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Введите рост в сантиметрах:");
            int height = int.Parse(Console.ReadLine());

            Console.Write("Введите вес:");
            int weight = int.Parse(Console.ReadLine());

            Console.WriteLine("Имя: " + name + ", Фамилия: " + surname + ", Возраст: " + age + " лет, " + "Рост: " + height + " см" + ", Вес: " + weight + " кг"); // a
            Console.WriteLine("Имя: {0}, Фамилия: {1}, Возраст: {2} лет, Рост: {3} см, Вес: {4} кг", name, surname, age, height, weight); // б
            Console.WriteLine($"Имя: {name}, Фамилия: {surname}, Возраст: {age} лет, Рост: {height} см, Вес: {weight} кг"); // в

            Console.ReadLine();
        }
    }
}