using System;

namespace ConstReadOnly
{
    class Program
    {
        static void Main()
        {
            /* Константы неявно являются статическим полем, для обращения к ней 
             необходимо использовать имя класса.*/
            Console.WriteLine(MathLib.PI);
            MathLib mLib = new();
            Console.WriteLine(mLib.GetCircleArea(4.5));
        }
    }

    /* Структуры только для чтения. Всё их содержимое должно быть так же для чтения */
    readonly struct User
    {
        public readonly string name;
        public int Age { get; } // Тоже касается и свойств, только для чтения
        public User (string name, int age) { this.name = name; this.Age = age; }
    }
}
