using System;

namespace SimpleClassConstruct
{
    class Program
    {
        static void Main()
        {
            Person tom = new();  // Вызов конструктора без параметров
            Person bob = new("Bob"); // Вызов конструктора с одним параметром
            Person sam = new("Sam", 25); // Вызов конструктора с 2мя параметрами
            Person jeff = new() { name = "Jeff", age = 31 };    // Инициализация объектов без конструктора
            BetterPerson tim = new BetterPerson("tim",20,"aassas@gsga.com");
            tim.GetInfo();
            tom.GetInfo();  // Имя:Неизвестно  Возраст:18
            bob.GetInfo();  // Имя:Bob Возраст:18
            sam.GetInfo();  // Имя:Sam Возраст:25
            jeff.GetInfo();
            tom.name = "Tom";
            tom.age = 34;
            tom.GetInfo(); // Имя: Tom Возраст: 34
            Console.ReadKey();
        }
    }
    class Person
    {
        /* Поля класса */
        public string name; // Имя
        public int age; // Возраст

        /* Конструкторы для создания нового объекта класса */
        public Person() : this("Неизвестно") { }    // 1 конструктор 
        public Person(string name) : this (name,18) {} // 2 конструктор
        public Person(string name, int age) { this.name = name;this.age = age; } // 3 конструктор
        
        /* Метод выводящий содержимое объекта класса */
        public void GetInfo()
        {
            Console.WriteLine($"Имя: {name} возраст: {age}");
        }

    }
    class BetterPerson
    {
        public string name;
        public int age;
        public string email;

        /* Более наглядное использование this */
        public BetterPerson(string name) { this.name = name; }
        public BetterPerson(string name, int age) : this(name) { this.age = age; }
        public BetterPerson(string name, int age, string email) : this(name, age) { this.email = email; }

        public void GetInfo()
        {
            Console.WriteLine($"Имя: {name} возраст: {age} емейл: {email}");
        }
    }
}
