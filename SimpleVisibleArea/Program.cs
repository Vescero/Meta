﻿using System;   // Подключаемое пространство имён

namespace SimpleVisibleArea // Объявление пространства имён
{
    class Program   // Начало контекста класса
    {
        static int a = 9; // переменная уровня класса
        static int z = 5; // переменная уровня класса
        static void Main()  // Начало контекста метода Main
        {
            int z = 3;  // Переменная уровня метода скрывает переменную на уровне класса
            Console.WriteLine(z);   // 3
            int b = a - 1;  // Переменная уровня метода
            string message = "hello";
            Display(message);
            {   // Начало контекста блока кода
                int c = b - 1;  // Переменная уровня блока кода
            }   // Конец контекста блока кода, переменная с уничтожается
            //Console.WriteLine(c);  так нельзя, переменная с определена в блоке кода
            //Console.WriteLine(d);  так нельзя, переменная d определена в другом методе
            Console.ReadKey();
        }   // Конец контекста метода Main, переменная b уничтожается
        static void Display()   // Начало контекста метода Display
        {
            // Переменная a опеределена в контекста класса, поэтому доступна
            int d = a + 1;
        }   // Конец контекста метода Display, переменная d уничтожается

        static void Display (string message)
        {
            Console.WriteLine(message);
        }
    }   // Конец контекста класса, переменная a уничтожается
}