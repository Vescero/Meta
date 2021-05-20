using System;               // Подключение пространства имён

namespace SimpleTryCatch    // Объявление пространсва имён
{
    class Program           // Объявление класса
    {
        static void Main()  // Объявление метода
        {
            try     // Действия в которых потенциально может возникнуть ошибка
            {
                int a = 33;
                int b = 600;
                byte c = checked((byte)(a + b));    // Ключевое слово после которого приложение проверяет на ошибки и генерирует исключение
                Console.WriteLine(c);
            }
            catch (OverflowException exception) // Обработка ошибки
            {
                Console.WriteLine(exception.Message);   // Вывод содержимого ошибки на экран
            }
        }                   // Конец объявления метода
    }                       // Конец объявления класса
}                           // Конец объявления пространства имён
