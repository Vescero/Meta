using System;                           // подключаемое пространство имен

namespace HelloApp                      // объявление нового пространства имен
{
    class Program                       // объявление нового класса
    {
        static void Main(string[] args) // объявление нового метода
        {
            /* Действия метода */
            Console.WriteLine("Введите своё имя");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}");
        }                               // конец объявления нового метода
    }                                   // конец объявления нового класса
}                                       // конец объявления нового пространства имен
