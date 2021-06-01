using System;

namespace SimpleStruct
{
    class Program
    {
        static void Main()
        {
            User tom;   // Создание объекта структуры
            /* Инициализация полей (Обязательно!)*/
            tom.name = "Tom";
            tom.age = 34;
            tom.DisplayInfo();  // Tom, 34
            /* Вызов конструктора */
            User jeff = new User("Jeff", 50);
            jeff.DisplayInfo(); // Jeff, 50
            /* Вызов конструктора без параметров (по умолчанию) */
            User claus = new User();
            claus.DisplayInfo(); // " ", 0
            /* Использование инициализатора для создания*/
            User max = new User() { name = "Max", age = 17 };
            max.DisplayInfo();
        }
        struct User
        {
            /* Переменные */
            //public string secondName = "tt"; // Инициализация при объявлении не допускается
            public string name;
            public int age;
            /* Конструктор */
            public User (string name, int age){this.name = name; this.age = age;}
            /* Методы */
            public void DisplayInfo()
            {
                Console.WriteLine($"Name:{name} Age:{age}");
            }
        }
    }
}
