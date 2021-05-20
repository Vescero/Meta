using System;                                   // Подключение пространства имён

namespace ConsoleInputOutput                    // Объявление пространства имён
{
    class Program                               // Объявление класса
    {
        static void Main()                      // Объявление метода
        {
            // Блок операторов
            Console.Write("Введите имя: ");     // Запрашиваем ввод
            string name = Console.ReadLine();   // Считываем ввод
            Console.Write("Введите возраст: ");
            byte age = Convert.ToByte(Console.ReadLine());
            Console.Write("Введите рост: ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите размер зарплаты: ");
            decimal salary = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine($"Имя: {name} Возраст: {age} Рост: {height} Зарплата: {salary}"); // Интерполяция значений переменных и вывод их на экран
            Console.ReadKey();
            // Конец блока операторов
        }                                       // Конец объявления метода
    }                                           // Конец объявление класса
}                                               // Конец объявления пространства имён
